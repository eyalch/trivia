#include "Database.h"
#include "sqlite3.h"
#include <exception>
#include <iostream>


Database::Database()
{
	if (FILE* file = fopen(DB_NAME, "r"))
	{
		fclose(file);

		if (_rc = sqlite3_open(DB_NAME, &_db))
		{
			sqlite3_close(_db);
			throw std::exception(sqlite3_errmsg(_db));
		}
	}
	else
		throw std::exception("Database doesn't exist!");
}


Database::~Database()
{
	sqlite3_close(_db);
}


void Database::clearTable()
{
	for (auto &it : _results)
		it.second.clear();
	_results.clear();
}


int Database::callback(void* notUsed, int argc, char** argv, char** azCol)
{
	for (int i = 0; i < argc; i++)
	{
		auto it = _results.find(azCol[i]);
		if (it != _results.end())
		{
			it->second.push_back(argv[i]);
		}
		else
		{
			std::pair<std::string, std::vector<std::string>> p;
			p.first = azCol[i];
			p.second.push_back(argv[i]);
			_results.insert(p);
		}
	}

	return 0;
}


bool Database::isUserExists(std::string username)
{
	clearTable();

	std::string q = "SELECT COUNT(*) AS count FROM t_users WHERE username=" + username;

	if ((_rc = sqlite3_exec(_db, q.c_str(), callback, 0, &_zErrMsg)) != SQLITE_OK)
	{
		std::cout << "SQL error: " << _zErrMsg << std::endl;
		sqlite3_free(_zErrMsg);

		return false;
	}
	else
	{
		return atoi(_results["count"][0].c_str()) > 0;
	}
}


bool Database::addNewUser(std::string username, std::string password, std::string email)
{
	clearTable();

	std::string q = "INSERT INTO t_users (username, password, email) VALUES (" + username + ", " + password + ", " + email + ')';

	if ((_rc = sqlite3_exec(_db, q.c_str(), callback, 0, &_zErrMsg)) != SQLITE_OK)
	{
		std::cout << "SQL error: " << _zErrMsg << std::endl;
		sqlite3_free(_zErrMsg);

		return false;
	}
	
	return true;
}


bool Database::isUserAndPassMatch(std::string username, std::string password)
{
	clearTable();

	std::string q = "SELECT password FROM t_users WHERE username=" + username;

	if ((_rc = sqlite3_exec(_db, q.c_str(), callback, 0, &_zErrMsg)) != SQLITE_OK)
	{
		std::cout << "SQL error: " << _zErrMsg << std::endl;
		sqlite3_free(_zErrMsg);

		return false;
	}
	else
	{
		return _results["password"][0] == password;
	}
}


std::vector<Question*> Database::initQuestions(int questionsNo)
{
	std::vector<Question*> questions;

	clearTable();

	std::string q = "SELECT * FROM t_questions ORDER BY RAND() LIMIT " + questionsNo;

	if ((_rc = sqlite3_exec(_db, q.c_str(), callback, 0, &_zErrMsg)) != SQLITE_OK)
	{
		std::cout << "SQL error: " << _zErrMsg << std::endl;
		sqlite3_free(_zErrMsg);
	}
	else
	{
		for (int i = 0; i < _results.size(); i++)
			questions.push_back(new Question(atoi(_results["question_id"][i].c_str()), _results["question"][i], _results["correct_ans"][i], _results["ans2"][i], _results["ans3"][i], _results["ans4"][i]));
	}

	return questions;
}


std::vector<std::string> Database::getBestScores()
{

}


std::vector<std::string> Database::getPersonalStatus(std::string)
{

}


int Database::insertNewGame()
{
	clearTable();

	std::string q = "INSERT INTO t_games (status, start_time) VALUES (0, datetime(YYYY-MM-DD HH:MM:SS))";

	if ((_rc = sqlite3_exec(_db, q.c_str(), callback, 0, &_zErrMsg)) != SQLITE_OK)
	{
		std::cout << "SQL error: " << _zErrMsg << std::endl;
		sqlite3_free(_zErrMsg);
	}
}

