#include "TriviaServer.h"
#include <sstream>


TriviaServer::TriviaServer()
{
	_db = Database();

	WSADATA wsaData;
	int iResult;

	if ((iResult = WSAStartup(MAKEWORD(2, 2), &wsaData)) != 0)
	{
		std::stringstream ex;
		ex << "WSAStartup failed: " << iResult << "\n";

		throw std::exception(ex.str().c_str());
	}
}

TriviaServer::~TriviaServer()
{
}
