#include "TriviaServer.h"
#include "Helper.h"
#include <sstream>

static const unsigned short PORT = 8820;
static const unsigned int IFACE = 0;

TriviaServer::TriviaServer()
{
	_db = Database();

	/*WSADATA wsaData;
	int iResult;

	if ((iResult = WSAStartup(MAKEWORD(2, 2), &wsaData)) != 0)
	{
		std::stringstream ex;
		ex << "WSAStartup failed: " << iResult << "\n";

		throw std::exception(ex.str().c_str());
	}*/

	if ((_socket = ::socket(AF_INET, SOCK_STREAM, IPPROTO_TCP)) == INVALID_SOCKET)
		throw std::exception(__FUNCTION__ " - socket");
}

TriviaServer::~TriviaServer()
{
	TRACE(__FUNCTION__ " closing accepting socket");

	for (auto i : _roomsList)
		delete i.second;

	for (auto i : _connectedUsers)
		delete i.second;

	try
	{
		::closesocket(_socket);
	}
	catch (...) {}
}

void TriviaServer::serve()
{
	bindAndListen();

	while (true)
	{
		TRACE("accepting client...");
		accept();
	}
}

void TriviaServer::bindAndListen()
{
	struct sockaddr_in sa = { 0 };
	sa.sin_port = htons(PORT);
	sa.sin_family = AF_INET;
	sa.sin_addr.s_addr = IFACE;

	if (::bind(_socket, (struct sockaddr*)&sa, sizeof(sa)) == SOCKET_ERROR)
		throw std::exception(__FUNCTION__ " - bind");
	TRACE("binded");

	if (::listen(_socket, SOMAXCONN) == SOCKET_ERROR)
		throw std::exception(__FUNCTION__ " - bind");
	TRACE("listening...");
}

void TriviaServer::accept()
{
	SOCKET client_socket = ::accept(_socket, NULL, NULL);
	if (client_socket == INVALID_SOCKET)
		throw std::exception(__FUNCTION__);

	TRACE("Client accepted!");

	std::thread tr(&TriviaServer::clientHandler, this, client_socket);
	tr.detach();
}

void TriviaServer::clientHandler(SOCKET client_socket)
{
	try
	{
		int msgType = Helper::getMessageTypeCode(_socket);
		while (msgType != 0 && msgType != 299)
		{
			
		}
	}
	catch (const std::exception&)
	{

	}
}

ReceivedMessage* TriviaServer::buildReceiveMessage(SOCKET client_socket, int msgCode)
{
	switch (msgCode)
	{
	case 200:
	{
		int userLen = Helper::getIntPartFromSocket(client_socket, 2);
		std::string user = Helper::getStringPartFromSocket(client_socket, userLen);

		int passLen = Helper::getIntPartFromSocket(client_socket, 2);
		std::string pass = Helper::getStringPartFromSocket(client_socket, passLen);

		return new ReceivedMessage(client_socket, msgCode, { user, pass });
	}
	case 201:
		return new ReceivedMessage(client_socket, msgCode);
	case 203:
	{
		int userLen = Helper::getIntPartFromSocket(client_socket, 2);
		std::string username = Helper::getStringPartFromSocket(client_socket, userLen);

		int passLen = Helper::getIntPartFromSocket(client_socket, 2);
		std::string pass = Helper::getStringPartFromSocket(client_socket, passLen);

		int emailLen = Helper::getIntPartFromSocket(client_socket, 2);
		std::string email = Helper::getStringPartFromSocket(client_socket, emailLen);

		return new ReceivedMessage(client_socket, msgCode, { username, pass, email });
	}
	case 205:
		return new ReceivedMessage(client_socket, msgCode);
	default:
		throw std::exception("Message Code wasn't found!");
		break;
	}

	return nullptr;
}
