#pragma once

#include <string>
#include <WinSock2.h>
#include <Windows.h>
#include "Room.h"
#include "Game.h"

class Room;
class Game;

class User
{
public:
	User(std::string username, SOCKET sock);

	void send(std::string message);  // Send a message to the user.
	std::string getUsername() { return _username; }
	SOCKET getSocket() { return _sock; }
	Room* getRoom() { return _room; }
	Game* getGame() { return _game; }
	void setGame(Game* gm);  // Get the user out of the room and into a game.
	void clearGame() { _game = nullptr; }
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

