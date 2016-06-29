#pragma once

#include <string>

class Validator
{
public:
	Validator() {}
	~Validator() {}

	static bool isPasswordValid(std::string password);  // At least 4 chars, no spaces, at least one digit, at least one upper-case letter and at least one lower-case letter.
	static bool isUsernameValid(std::string username);  // Must start with a letter, no spaces and not empty.
};
