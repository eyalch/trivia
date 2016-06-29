#include "TriviaServer.h"
#include "Helper.h"
#include "Protocol.h"
#include "Validator.h"
#include <sstream>
#include <iostream>

static const unsigned short PORT = 8820;
static const unsigned int IFACE = 0;

int TriviaServer::_roomIdSequence = 0;

TriviaServer::TriviaServer() : _db(), _queRcvMessages()
{
	WSADATA wsaData;
	int iResult;

	if (iResult = WSAStartup(MAKEWORD(2, 2), &wsaData))
	{
		std::stringstream ex;
		ex << "WSAStartup failed: " << iResult << "\n";

		throw std::exception(ex.str().c_str());
	}

	if ((_socket = ::socket(AF_INET, SOCK_STREAM, IPPROTO_TCP)) == INVALID_SOCKET)
	{
		std::cout << "WSA Error # " << WSAGetLastError() << std::endl;
		throw std::exception(__FUNCTION__ " - socket");
	}

	std::thread tr(&TriviaServer::handleReceivedMessages, this);
	tr.detach();
}

TriviaServer::~TriviaServer()
{
	TRACE(__FUNCTION__ " closing accepting socket");

	for (auto i : _roomsList)
		delete i.second;

	for (auto i : _connectedUsers)
		delete i.second;

	try
	{
		::closesocket(_socket);
		WSACleanup();
	}
	catch (...) {}
}

void TriviaServer::serve()
{
	bindAndListen();

	while (true)
	{
		TRACE("accepting client...");
		accept();
	}
}

void TriviaServer::bindAndListen()
{
	struct sockaddr_in sa = { 0 };
	sa.sin_port = htons(PORT);
	sa.sin_family = AF_INET;
	sa.sin_addr.s_addr = IFACE;

	if (::bind(_socket, (struct sockaddr*)&sa, sizeof(sa)) == SOCKET_ERROR)
		throw std::exception(__FUNCTION__ " - bind");
	TRACE("binded");

	if (::listen(_socket, SOMAXCONN) == SOCKET_ERROR)
		throw std::exception(__FUNCTION__ " - bind");
	TRACE("listening...");
}

void TriviaServer::accept()
{
	SOCKET client_socket = ::accept(_socket, NULL, NULL);
	if (client_socket == INVALID_SOCKET)
		throw std::exception(__FUNCTION__);

	TRACE("Client accepted!");

	std::thread tr(&TriviaServer::clientHandler, this, client_socket);
	tr.detach();
}

void TriviaServer::clientHandler(SOCKET client_socket)
{
	try
	{
		int msgType = Helper::getMessageTypeCode(client_socket);
		while (msgType != 0 && msgType != 299)
		{
			ReceivedMessage * rcvMsg = buildReceiveMessage(client_socket, msgType);

			addReveivedMessage(rcvMsg);

			msgType = Helper::getMessageTypeCode(client_socket);
		}

		addReveivedMessage(new ReceivedMessage(client_socket, 299));
	}
	catch (const std::exception&)
	{
		addReveivedMessage(new ReceivedMessage(client_socket, 299));
	}
}

void TriviaServer::safeDeleteUser(ReceivedMessage * msg)
{
	try
	{
		handleSignout(msg);

		::closesocket(msg->getSock());
	}
	catch (const std::exception&)
	{

	}
}

User * TriviaServer::handleSignin(ReceivedMessage * msg)
{
	std::vector<std::string> values = msg->getValues();

	std::string
		username = values[0],
		password = values[1];

	msg->setUser(new User(username, msg->getSock()));

	if (_db.isUserAndPassMatch(username, password))
	{
		if (getUserByName(username) != nullptr)
		{
			msg->getUser()->send(SIGN_IN_RESPONSE_ALREADY_CONNECTED);

			return nullptr;
		}
		else
		{
			User * newUser = new User(username, msg->getSock());
			_connectedUsers[msg->getSock()] = newUser;
			newUser->send(SIGN_IN_RESPONSE_SUCCESS);

			return newUser;
		}
	}
	else
	{
		msg->getUser()->send(SIGN_IN_RESPONSE_WRONG_DETAILS);

		return nullptr;
	}
}

bool TriviaServer::handleSignup(ReceivedMessage * msg)
{
	std::vector<std::string> values = msg->getValues();

	std::string
		username = values[0],
		password = values[1],
		email = values[2];

	msg->setUser(new User(username, msg->getSock()));

	if (Validator::isPasswordValid(password))
	{
		if (Validator::isUsernameValid(username))
		{
			if (!_db.isUserExists(username))
			{
				if (_db.addNewUser(username, password, email))
				{
					msg->getUser()->send(SIGN_UP_RESPONSE_SUCCESS);

					return true;
				}
				else
				{
					msg->getUser()->send(SIGN_UP_RESPONSE_OTHER);

					return false;
				}
			}
			else
			{
				msg->getUser()->send(SIGN_UP_RESPONSE_USER_EXISTS);

				return false;
			}
		}
		else
		{
			msg->getUser()->send(SIGN_UP_RESPONSE_USER_ILLEGAL);

			return false;
		}
	}
	else
	{
		msg->getUser()->send(SIGN_UP_RESPONSE_PASS_ILLEGAL);

		return false;
	}
}

void TriviaServer::handleSignout(ReceivedMessage * msg)
{
	if (msg->getUser() != nullptr)
	{
		_connectedUsers.erase(msg->getUser()->getSocket());

		handleCloseRoom(msg);
		handleLeaveRoom(msg);
		handleLeaveGame(msg);
	}
}

void TriviaServer::handleLeaveGame(ReceivedMessage * msg)
{
	if (!msg->getUser()->leaveGame())
		delete msg->getUser()->getGame();
}

void TriviaServer::handleStartGame(ReceivedMessage * msg)
{
	try
	{
		Room * room = msg->getUser()->getRoom();
		Game * game = new Game(room->getUsers(), room->getQuestionsNo(), _db);

		_roomsList.erase(room->getId());

		game->sendFirstQuestion();
	}
	catch (const std::exception&)
	{
		msg->getUser()->send(QUESTION + '0');
	}
}

void TriviaServer::handlePlayerAnswer(ReceivedMessage * msg)
{
	Game * game = msg->getUser()->getGame();

	std::vector<std::string> values = msg->getValues();

	if (game != nullptr)
	{
		if (!game->handleAnswerFromUser(msg->getUser(), atoi(values[0].c_str()), atoi(values[1].c_str())))
			delete game;
	}
}

bool TriviaServer::handleCreateRoom(ReceivedMessage * msg)
{
	if (msg->getUser() != nullptr)
	{
		std::vector<std::string> values = msg->getValues();

		std::string
			roomName = values[0],
			playersCount = values[1],
			questionsCount = values[2],
			timeForQuestion = values[3];

		TriviaServer::_roomIdSequence++;

		if (msg->getUser()->createRoom(_roomIdSequence, roomName, atoi(playersCount.c_str()), atoi(questionsCount.c_str()), atoi(timeForQuestion.c_str())))
		{
			_roomsList[msg->getUser()->getRoom()->getId()] = msg->getUser()->getRoom();

			return true;
		}
		else
			return false;
	}
	else
		return false;
}

bool TriviaServer::handleCloseRoom(ReceivedMessage * msg)
{
	if (msg->getUser()->getRoom() != nullptr)
	{
		int roomId;

		if ((roomId = msg->getUser()->closeRoom()) != -1)
		{
			_roomsList.erase(roomId);

			return true;
		}
		else
			return false;
	}
	else
		return false;
}

bool TriviaServer::handleJoinRoom(ReceivedMessage * msg)
{
	User * user = msg->getUser();
	if (user != nullptr)
	{
		int roomId = atoi(msg->getValues()[0].c_str());

		Room * room = getRoomById(roomId);

		if (room != nullptr)
		{
			return user->joinRoom(room);
		}
		else
		{
			user->send(JOIN_ROOM_RESPONSE_NO_ROOM_OR_OTHER);

			return false;
		}
	}
	else
		return false;
}

bool TriviaServer::handleLeaveRoom(ReceivedMessage * msg)
{
	if (msg->getUser() != nullptr)
		if (msg->getUser()->getRoom() != nullptr)
		{
			msg->getUser()->leaveRoom();

			return true;
		}
		else
			return false;
	else
		return false;
}

void TriviaServer::handleGetUsersInRoom(ReceivedMessage * msg)
{
	int roomId = atoi(msg->getValues()[0].c_str());

	Room * room = getRoomById(roomId);

	if (room != nullptr)
		msg->getUser()->send(room->getUsersListMessage());
	else
		msg->getUser()->send(USERS_IN_ROOM_RESPONSE_NO_ROOM);
}

void TriviaServer::handleGetRooms(ReceivedMessage * msg)
{
	std::stringstream s;
	
	s << LIVE_ROOMS_RESPONSE;

	s << Helper::getPaddedNumber(_roomsList.size(), 4);

	if (_roomsList.size() > 0)
	{
		for (std::pair<int, Room *> i : _roomsList)
		{
			s << Helper::getPaddedNumber(i.second->getId(), 4);
			s << Helper::getPaddedNumber(i.second->getName().size(), 2);
			s << i.second->getName();
		}
	}

	msg->getUser()->send(s.str());
}

void TriviaServer::handleGetBestScores(ReceivedMessage * msg)
{
	std::vector<std::string> bestScores = _db.getBestScores();

	std::stringstream s;
	
	s << BEST_SCORES_RESPONSE;

	for (std::string &i : bestScores)
	{
		s << i;
	}

	for (size_t i = 0; i < 3 - bestScores.size(); i++)
	{
		s << Helper::getPaddedNumber(0, 2);
		s << Helper::getPaddedNumber(0, 6);
	}

	msg->getUser()->send(s.str());
}

void TriviaServer::handleGetPersonalStatus(ReceivedMessage * msg)
{
	std::vector<std::string> personalStatus = _db.getPersonalStatus(msg->getUser()->getUsername());

	int games_count = atoi(personalStatus[0].c_str());
	int correct_answers = atoi(personalStatus[1].c_str());
	int incorrect_answers = atoi(personalStatus[2].c_str());
	float answer_time = (float) atof(personalStatus[3].c_str());

	std::stringstream s;

	s << PERSONAL_STATUS_RESPONSE;

	s << Helper::getPaddedNumber(games_count, 4);
	s << Helper::getPaddedNumber(correct_answers, 6);
	s << Helper::getPaddedNumber(incorrect_answers, 6);
	s << Helper::getPaddedNumber((int) answer_time, 2);
	s << Helper::getPaddedNumber((answer_time - (int) answer_time) * 100, 2);

	msg->getUser()->send(s.str());
}

ReceivedMessage * TriviaServer::buildReceiveMessage(SOCKET client_socket, int msgCode)
{
	switch (msgCode)
	{
	case 200:
	{
		int userLen = Helper::getIntPartFromSocket(client_socket, 2);
		std::string user = Helper::getStringPartFromSocket(client_socket, userLen);

		int passLen = Helper::getIntPartFromSocket(client_socket, 2);
		std::string pass = Helper::getStringPartFromSocket(client_socket, passLen);

		return new ReceivedMessage(client_socket, msgCode, { user, pass });
	}
	case 201:
		return new ReceivedMessage(client_socket, msgCode);
	case 203:
	{
		int userLen = Helper::getIntPartFromSocket(client_socket, 2);
		std::string username = Helper::getStringPartFromSocket(client_socket, userLen);

		int passLen = Helper::getIntPartFromSocket(client_socket, 2);
		std::string pass = Helper::getStringPartFromSocket(client_socket, passLen);

		int emailLen = Helper::getIntPartFromSocket(client_socket, 2);
		std::string email = Helper::getStringPartFromSocket(client_socket, emailLen);

		return new ReceivedMessage(client_socket, msgCode, { username, pass, email });
	}
	case 205:
		return new ReceivedMessage(client_socket, msgCode);
	case 207:
		return new ReceivedMessage(client_socket, msgCode, { Helper::getStringPartFromSocket(client_socket, 4) });
	case 209:
		return new ReceivedMessage(client_socket, msgCode, { Helper::getStringPartFromSocket(client_socket, 4) });
	case 211:
		return new ReceivedMessage(client_socket, msgCode);
	case 213:
	{
		int roomNameLen = Helper::getIntPartFromSocket(client_socket, 2);
		std::string roomName = Helper::getStringPartFromSocket(client_socket, roomNameLen);

		int playersCount = Helper::getIntPartFromSocket(client_socket, 1);

		int questionsCount = Helper::getIntPartFromSocket(client_socket, 2);

		int timeForQuestion = Helper::getIntPartFromSocket(client_socket, 2);

		return new ReceivedMessage(client_socket, msgCode, { roomName, std::to_string(playersCount), std::to_string(questionsCount), std::to_string(timeForQuestion) });
	}
	case 215:
		return new ReceivedMessage(client_socket, msgCode);
	case 217:
		return new ReceivedMessage(client_socket, msgCode);
	case 219:
	{
		int answerNumber = Helper::getIntPartFromSocket(client_socket, 1);

		int timeInSeconds = Helper::getIntPartFromSocket(client_socket, 2);

		return new ReceivedMessage(client_socket, msgCode, { std::to_string(answerNumber), std::to_string(timeInSeconds) });
	}
	case 222:
		return new ReceivedMessage(client_socket, msgCode);
	case 223:
		return new ReceivedMessage(client_socket, msgCode);
	case 225:
		return new ReceivedMessage(client_socket, msgCode);
	case 299:
		return new ReceivedMessage(client_socket, msgCode);
	default:
		throw std::exception("Message Code wasn't found!");
		break;
	}

	return nullptr;
}

void TriviaServer::addReveivedMessage(ReceivedMessage * msg)
{
	std::lock_guard<std::mutex> lock(_mtxReceivedMessages);
	_queRcvMessages.push(msg);

	_cv.notify_all();
}

void TriviaServer::handleReceivedMessages()
{
	while (true)
	{
		std::unique_lock<std::mutex> locker(_mtxReceivedMessages);
		_cv.wait(locker, [&] {return _queRcvMessages.size() != 0; });

		ReceivedMessage * rcvMsg = _queRcvMessages.front();
		_queRcvMessages.pop();

		locker.unlock();

		try
		{
			rcvMsg->setUser(getUserBySocket(rcvMsg->getSock()));

			int code = rcvMsg->getMessageCode();

			switch (code)
			{
			case 200:
				handleSignin(rcvMsg);
				break;
			case 201:
				handleSignout(rcvMsg);
				break;
			case 203:
				handleSignup(rcvMsg);
				break;
			case 205:
				handleGetRooms(rcvMsg);
				break;
			case 207:
				handleGetUsersInRoom(rcvMsg);
				break;
			case 209:
				handleJoinRoom(rcvMsg);
				break;
			case 211:
				handleLeaveRoom(rcvMsg);
				break;
			case 213:
				handleCreateRoom(rcvMsg);
				break;
			case 215:
				handleCloseRoom(rcvMsg);
				break;
			case 217:
				handleStartGame(rcvMsg);
				break;
			case 219:
				handlePlayerAnswer(rcvMsg);
				break;
			case 222:
				handleLeaveGame(rcvMsg);
				break;
			case 223:
				handleGetBestScores(rcvMsg);
				break;
			case 225:
				handleGetPersonalStatus(rcvMsg);
			case 299:
				safeDeleteUser(rcvMsg);
				break;
			default:
				safeDeleteUser(rcvMsg);
				break;
			}
		}
		catch (const std::exception&)
		{
			safeDeleteUser(rcvMsg);
		}
	}
}

User * TriviaServer::getUserByName(std::string username)
{
	for (std::pair<SOCKET, User *> i : _connectedUsers)
		if (i.second->getUsername() == username)
			return i.second;

	return nullptr;
}

User * TriviaServer::getUserBySocket(SOCKET client_socket)
{
	std::map<SOCKET, User *>::iterator it = _connectedUsers.find(client_socket);

	if (it != _connectedUsers.end())
		return (*it).second;
	else
		return nullptr;
}

Room * TriviaServer::getRoomById(int roomId)
{
	std::map<int, Room *>::iterator it = _roomsList.find(roomId);

	if (it != _roomsList.end())
		return (*it).second;
	else
		return nullptr;
}
