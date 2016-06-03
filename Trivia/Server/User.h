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
	~User();

	void send(std::string message);  // Send a message to the user.
	std::string getUsername();  // Returns a string which represents the username.
	SOCKET getSocket();  // Return a SOCKET type which represents the socket of the current user.
	Room* getRoom();  // Return the room of the current user.
	Game* getGame();  // Return the game of the current user.
	void setGame(Game* gm);  // Get the user out of the room and into a game.
	void clearGame();  // Disconnects player from the game.
	bool createRoom(int roomId, std::string roomName, int maxUsers, int questionNo, int questionTime);  // Creates room.
	bool joinRoom(Room* newRoom);  // Sets a room for the user.
	void leaveRoom();  // Disconnect the user from the room.
	int closeRoom();  // Close the room the user has created.
	bool leaveGame();  // Disconnect the user from the game.

private:
	std::string _username;
	SOCKET _sock;
	Game* _game;
	Room* _room;
};

