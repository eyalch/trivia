#include "Room.h"
#include "Helper.h"
#include "Protocol.h"
#include <sstream>
#include <algorithm>


Room::Room(int id, User * admin, std::string name, int maxUsers, int questionNo, int questionTime) : _id(id), _admin(admin), _name(name), _maxUsers(maxUsers), _questionNo(questionNo), _questionTime(questionTime)
{
	_users = std::vector<User*>();
	_users.push_back(admin);
}

std::string Room::getUsersAsString(std::vector<User *> usersList, User * excludeUser)
{
	std::stringstream usersListRes;

	for (User* user : usersList)
		if (user != excludeUser)
			usersListRes << user->getUsername() << ",";

	return usersListRes.str();
}

void Room::sendMessage(User * excludeUser, std::string message)
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

bool Room::joinRoom(User * user)
{
	if (_maxUsers > _users.size())
	{
		_users.push_back(user);

		user->send(JOIN_ROOM_RESPONSE_SUCCESS + Helper::getPaddedNumber(_questionNo, 2) + Helper::getPaddedNumber(_questionTime, 2));

		sendMessage(getUsersListMessage());

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
	if (std::find(_users.begin(), _users.end(), user) != _users.end())
		_users.erase(std::remove(_users.begin(), _users.end(), user), _users.end());

	user->send(LEAVE_ROOM_RESPONSE);

	sendMessage(user, getUsersListMessage());
}

int Room::closeRoom(User * user)
{
	if (user == _admin)
	{
		sendMessage(CLOSE_ROOM_RESPONSE);

		for (User * i : _users)
		{
			if (i != _admin)
				i->leaveRoom();
		}

		return _id;
	}
	else
		return -1;
}

std::string Room::getUsersListMessage()
{
	std::stringstream s;

	if (_users.size() > 0)
	{
		s << USERS_IN_ROOM_RESPONSE;

		s << _users.size();
		
		for (User * i : _users)
		{
			std::string name = i->getUsername();

			s << Helper::getPaddedNumber(name.size(), 2);
			s << name;
		}
	}
	else
		s << USERS_IN_ROOM_RESPONSE_NO_ROOM;

	return s.str();
}
