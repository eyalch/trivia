#pragma once

#include <string>
#include <WinSock2.h>
#include <Windows.h>
#include "Room.h"
#include "Game.h"

class User
{
public:
	User(std::string username, SOCKET sock);
	~User() {}

	void send(std::string message);  // Send a message to the user.
	void setGame(Game* gm);  // Get the user out of the romm and into a game.
	void clearGame();  // Disconnects player from the game.
	bool createRoom(int roomId, std::string roomName, int maxUsers, int questionNo, int questionTime);  // Creates room.

private:
	std::string _username;
	SOCKET _sock;
	Game* _game;
	Room* _room;
};

