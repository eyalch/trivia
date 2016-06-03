#include "User.h"
#include "Helper.h"
#include "Protocol.h"


User::User(std::string username, SOCKET sock) : _username(username), _sock(sock)
{
	_room = nullptr;
	_game = nullptr;
}


User::~User()
{
	// Check if user is the admin, if he is delete _room;
}


void User::send(std::string message)
{
	Helper::sendData(_sock, message);
}


std::string User::getUsername()
{
	return _username;
}


SOCKET User::getSocket()
{
	return _sock;
}


Room* User::getRoom()
{
	return _room;
}


Game* User::getGame()
{
	return _game;
}


void User::setGame(Game* gm)
{
	_room = nullptr;
	_game = gm;
}


void User::clearGame()
{
	_game = nullptr;
}


bool User::createRoom(int roomId, std::string roomName, int maxUsers, int questionNo, int questionTime)
{
	if (_room != nullptr)
	{
		send(CREATE_ROOM_RESPONSE_FAIL);
		
		return false;
	}
	else
	{
		_room = new Room(roomId, this, roomName, maxUsers, questionNo, questionTime);

		send(CREATE_ROOM_RESPONSE_SUCCESS);

		return true;
	}
}


bool User::joinRoom(Room* newRoom)
{
	if (_room != nullptr)
		return false;
	else
	{
		// Add user to newRoom!
	}
}


void User::leaveRoom()
{

}

