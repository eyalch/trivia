#pragma once

#include <WinSock2.h>
#include <Windows.h>
#pragma comment(lib, "ws2_32.lib")

#include <map>
#include <mutex>
#include <condition_variable>
#include <queue>

#include "User.h"
#include "Database.h"
#include "Room.h"
#include "ReceivedMessage.h"


class TriviaServer
{
public:
	TriviaServer();
	~TriviaServer();

	void serve();

private:
	SOCKET _socket;
	std::map<SOCKET, User *> _connectedUsers;
	Database _db;
	std::map<int, Room *> _roomsList;

	std::queue<ReceivedMessage *> _queRcvMessages;

	std::mutex _mtxReceivedMessages;
	std::condition_variable _cv;

	static int _roomIdSequence;

	void bindAndListen();
	void accept();
	void clientHandler(SOCKET client_socket);
	void safeDeleteUser(ReceivedMessage * msg);

	User * handleSignin(ReceivedMessage * msg);
	bool handleSignup(ReceivedMessage * msg);
	void handleSignout(ReceivedMessage * msg);

	void handleLeaveGame(ReceivedMessage * msg);
	void handleStartGame(ReceivedMessage * msg);
	void handlePlayerAnswer(ReceivedMessage * msg);

	bool handleCreateRoom(ReceivedMessage * msg);
	bool handleCloseRoom(ReceivedMessage * msg);
	bool handleJoinRoom(ReceivedMessage * msg);
	bool handleLeaveRoom(ReceivedMessage * msg);
	void handleGetUsersInRoom(ReceivedMessage * msg);
	void handleGetRooms(ReceivedMessage * msg);

	void handleGetBestScores(ReceivedMessage * msg);
	void handleGetPersonalStatus(ReceivedMessage * msg);

	void handleReceivedMessages();	
	void addReveivedMessage(ReceivedMessage* msg);
	ReceivedMessage * buildReceiveMessage(SOCKET client_socket, int msgCode);

	User * getUserByName(std::string username);
	User * getUserBySocket(SOCKET client_socket);
	Room * getRoomById(int roomId);
};
