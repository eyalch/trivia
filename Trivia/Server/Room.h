#pragma once

#include <vector>
#include <sstream>
#include "User.h"

class User;

class Room
{
public:
	Room(int id, User * admin, std::string name, int maxUsers, int questionNo, int questionTime);

	bool joinRoom(User * user);
	void leaveRoom(User * user);
	int closeRoom(User * user);
	std::vector<User *> getUsers() { return _users; }
	std::string getUsersListMessage();
	int getQuestionsNo() { return _questionNo; }
	int getId() { return _id; }
	std::string getName() { return _name; }

private:
	std::vector<User *> _users;
	User * _admin;
	unsigned int _maxUsers;
	int _questionTime, _questionNo, _id;
	std::string _name;

	std::string getUsersAsString(std::vector<User *> usersList, User * excludeUser);
	void sendMessage(User * excludeUser, std::string message);
	void sendMessage(std::string message);
};

