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
	Helper::sendData(_sock, message);
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
		send()
}

