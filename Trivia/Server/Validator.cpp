#include "Validator.h"


bool Validator::isPasswordValid(std::string password)
{
	if (password.length() < 4)
		return false;
	else if (password.find_first_of(' ') != std::string::npos)
		return false;
	else if (password.find_first_of("0123456789") == std::string::npos)
		return false;
	else if (password.find_first_of("abcdefghijklmnopqrstuvwxyz") == std::string::npos)
		return false;
	else if (password.find_first_of("ABCDEFGHIJKLMNOPQRSTUVWXYZ") == std::string::npos)
		return false;
	else
		return true;
}

bool Validator::isUsernameValid(std::string username)
{
	if (username == "")
		return false;
	else if (username.find_first_of(' ') != std::string::npos)
		return false;
	else if (username.find_first_of("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz") != 0)
		return false;
	else
		return true;
}
