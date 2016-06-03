#pragma once

#include <vector>
#include "Room.h"
#include "User.h"

class Room
{
public:
	Room(int id, User* admin, std::string name, int maxUsers, int questionNo, int questionTime);



private:
	std::vector<User*> _users;
	User* _admin;
	int _maxUsers;
	int _questionTime;
	int _questionNo;
	std::string _name;
	int _id;

	std::string getUsersAsString(std::vector<User*> usersList, User* excludeUser);
	void sendMessage(User* excludeUser, std::string message);
	void sendMessage(std::string message);
};

