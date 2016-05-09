#include "User.h"


User::User(std::string username, SOCKET sock) : _username(username), _sock(sock)
{
	_room = nullptr;
	_game = nullptr;
}


User::~User()
{
}


void User::send(std::string message)
{

}


void User::setGame(Game * gm)
{
	_room = nullptr;
	_game = gm;
}



