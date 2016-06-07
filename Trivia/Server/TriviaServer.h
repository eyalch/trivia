#pragma once

#include <WinSock2.h>
#include <Windows.h>
#include <map>
#include <mutex>
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

private:
	SOCKET _socket;
	std::map<SOCKET, User*> _connectedUsers;
	Database _db;
	std::map<int, Room*> _roomsList;

	std::mutex _mtxReceivedMessages;
	std::queue<ReceivedMessage*> _queRcvMessages;

	static int _roomIdSequence;
};
