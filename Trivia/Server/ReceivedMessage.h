#pragma once

#include "User.h"

class ReceivedMessage
{
public:
	ReceivedMessage(SOCKET client_socket, int msgCode, std::vector<std::string> values) : _sock(client_socket), _messageCode(msgCode), _values(values) { _user = nullptr; }
	ReceivedMessage(SOCKET client_socket, int msgCode) : ReceivedMessage(client_socket, msgCode, {}) {  }

	SOCKET getSock() { return _sock; }
	User * getUser() { return _user; }
	void setUser(User * user) { _user = user; }
	int getMessageCode() { return _messageCode; }
	std::vector<std::string>& getValues() { return _values; }

private:
	SOCKET _sock;
	User * _user;
	int _messageCode;
	std::vector<std::string> _values;
};
