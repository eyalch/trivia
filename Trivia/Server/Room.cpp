#include "Room.h"
#include <sstream>
#include "Helper.h"
#include "Protocol.h"


Room::Room(int id, User* admin, std::string name, int maxUsers, int questionNo, int questionTime) : _id(id), _admin(admin), _name(name), _maxUsers(maxUsers), _questionNo(questionNo), _questionTime(questionTime)
{
	_users = std::vector<User*>();
	_users.push_back(admin);
}

std::string Room::getUsersAsString(std::vector<User*> usersList, User* excludeUser)
{
	std::stringstream usersListRes;

	for (User* user : usersList)
		if (user != excludeUser)
			usersListRes << user->getUsername() << ",";

	return usersListRes.str();
}

void Room::sendMessage(User* excludeUser, std::string message)
{
	for (User* user : _users)
		if (user != excludeUser)
		{
			try
			{
				user->send(message);
			}
			catch (std::exception ex)
			{
				TRACE(ex.what());
			}
		}
}

void Room::sendMessage(std::string message)
{
	sendMessage(nullptr, message);
}

bool Room::joinRoom(User* user)
{
	if (_maxUsers > _users.size())
	{
		_users.push_back(user);

		user->send(JOIN_ROOM_RESPONSE_SUCCESS);

		sendMessage(getUsersAsString(_users, nullptr));

		return true;
	}
	else
	{
		user->send(JOIN_ROOM_RESPONSE_ROOM_FULL);

		return false;
	}
}

void Room::leaveRoom(User * user)
{

}
