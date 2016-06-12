#pragma once

#include <vector>
#include "User.h"

class User;

class Room
{
public:
	Room(int id, User* admin, std::string name, int maxUsers, int questionNo, int questionTime);

	bool joinRoom(User* user);
	void leaveRoom(User* user);

private:
	std::vector<User*> _users;
	User* _admin;
	unsigned int _maxUsers;
	int _questionTime;
	int _questionNo;
	std::string _name;
	int _id;

	std::string getUsersAsString(std::vector<User*> usersList, User* excludeUser);
	void sendMessage(User* excludeUser, std::string message);
	void sendMessage(std::string message);
};

