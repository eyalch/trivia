#include "User.h"
#include "Helper.h"
#include "Protocol.h"


User::User(std::string username, SOCKET sock) : _username(username), _sock(sock)
{
	_room = nullptr;
	_game = nullptr;
}

void User::send(std::string message)
{
	try
	{
		Helper::sendData(_sock, message);
	}
	catch (const std::exception&)
	{
		
	}
}

void User::setGame(Game* gm)
{
	_room = nullptr;
	_game = gm;
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

	return false;
}

void User::leaveRoom()
{
	if (_room != nullptr)
	{
		// _room->leaveRoom()

		_room = nullptr;
	}
}

int User::closeRoom()
{
	int roomId = -1;

	if (_room != nullptr)
	{
		if ((roomId /*= _room->closeRoom()*/) != -1)
		{
			delete _room;
			_room = nullptr;
		}
	}
	
	return roomId;
}

bool User::leaveGame()
{
	if (_game != nullptr)
	{
		// _game->leaveGame()

		_game = nullptr;
	}

	return false;
}
