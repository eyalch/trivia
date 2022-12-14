#include "Database.h"
#include "Helper.h"
#include "sqlite3.h"
#include <exception>
#include <iostream>
#include <sstream>


std::unordered_map<std::string, std::vector<std::string>> Database::_results;

Database::Database()
{
	FILE * file;
	errno_t err = fopen_s(&file, DB_NAME, "r");
	if (!err)
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

void Database::clearTable()
{
	for (auto &it : _results)
		it.second.clear();
	_results.clear();
}

int Database::callback(void * notUsed, int argc, char ** argv, char ** azCol)
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

	std::stringstream q;
	q << "SELECT COUNT(*) AS count FROM t_users WHERE username=\'" << username << '\'';

	if ((_rc = sqlite3_exec(_db, q.str().c_str(), callback, 0, &_zErrMsg)) != SQLITE_OK)
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

	std::stringstream q;
	q << "INSERT INTO t_users (username, password, email) VALUES (\'" << username << "\', \'" << password << "\', \'" << email << "\')";

	if ((_rc = sqlite3_exec(_db, q.str().c_str(), callback, 0, &_zErrMsg)) != SQLITE_OK)
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

	std::stringstream q;
	q << "SELECT password FROM t_users WHERE username=\'" << username << '\'';

	if ((_rc = sqlite3_exec(_db, q.str().c_str(), callback, 0, &_zErrMsg)) != SQLITE_OK)
	{
		std::cout << "SQL error: " << _zErrMsg << std::endl;
		sqlite3_free(_zErrMsg);

		return false;
	}
	else
	{
		if (_results["password"].size() > 0)
			return _results["password"][0] == password;
		return false;
	}
}

std::vector<Question *> Database::initQuestions(int questionsNo)
{
	std::vector<Question *> questions;

	clearTable();

	std::stringstream q;
	q << "SELECT * FROM t_questions ORDER BY RANDOM() LIMIT " << questionsNo;

	if ((_rc = sqlite3_exec(_db, q.str().c_str(), callback, 0, &_zErrMsg)) != SQLITE_OK)
	{
		std::cout << "SQL error: " << _zErrMsg << std::endl;
		sqlite3_free(_zErrMsg);
	}
	else
	{
		for (size_t i = 0; i < _results["question_id"].size(); i++)
			questions.push_back(new Question(atoi(_results["question_id"][i].c_str()), _results["question"][i], _results["correct_ans"][i], _results["ans2"][i], _results["ans3"][i], _results["ans4"][i]));
	}

	return questions;
}

std::vector<std::string> Database::getBestScores()
{
	std::vector<std::string> bestScores;

	clearTable();

	std::stringstream q;
	q << "SELECT SUM(is_correct) AS score, username FROM t_players_answers GROUP BY username ORDER BY score DESC LIMIT 3";

	if ((_rc = sqlite3_exec(_db, q.str().c_str(), callback, 0, &_zErrMsg)) != SQLITE_OK)
	{
		std::cout << "SQL error: " << _zErrMsg << std::endl;
		sqlite3_free(_zErrMsg);
	}
	else
	{
		for (size_t i = 0; i < _results["username"].size(); i++)
		{
			bestScores.push_back(Helper::getPaddedNumber(_results["username"][i].size(), 2) + _results["username"][i] + Helper::getPaddedNumber(atoi(_results["score"][i].c_str()), 6));
		}
	}

	return bestScores;
}

std::vector<std::string> Database::getPersonalStatus(std::string username)
{
	std::vector<std::string> personalStatus;

	clearTable();

	std::stringstream q;
	q << "SELECT COUNT(DISTINCT game_id) AS games_count, SUM(is_correct) AS correct_answers FROM t_players_answers WHERE username=\'" << username << '\'';

	if ((_rc = sqlite3_exec(_db, q.str().c_str(), callback, 0, &_zErrMsg)) != SQLITE_OK)
	{
		std::cout << "SQL error: " << _zErrMsg << std::endl;
		sqlite3_free(_zErrMsg);
	}
	else
	{
		personalStatus.push_back(_results["games_count"][0]);
		personalStatus.push_back(_results["correct_answers"][0]);
	}

	clearTable();

	q.str(std::string());

	q << "SELECT COUNT(game_id) AS incorrect_answers FROM t_players_answers WHERE username=\'" << username << "\' AND is_correct=0";

	if ((_rc = sqlite3_exec(_db, q.str().c_str(), callback, 0, &_zErrMsg)) != SQLITE_OK)
	{
		std::cout << "SQL error: " << _zErrMsg << std::endl;
		sqlite3_free(_zErrMsg);
	}
	else
	{
		personalStatus.push_back(_results["incorrect_answers"][0]);
	}

	clearTable();

	q.str(std::string());

	q << "SELECT AVG(answer_time) AS avg_answer_time FROM t_players_answers WHERE username=\'" << username << '\'';

	if ((_rc = sqlite3_exec(_db, q.str().c_str(), callback, 0, &_zErrMsg)) != SQLITE_OK)
	{
		std::cout << "SQL error: " << _zErrMsg << std::endl;
		sqlite3_free(_zErrMsg);
	}
	else
	{
		personalStatus.push_back(_results["avg_answer_time"][0]);
	}

	return personalStatus;
}

int Database::insertNewGame()
{
	clearTable();

	std::stringstream q;
	q << "INSERT INTO t_games (status, start_time) VALUES (0, datetime('now', '+3 hours'));SELECT MAX(game_id) AS game_id FROM t_games";

	if ((_rc = sqlite3_exec(_db, q.str().c_str(), callback, 0, &_zErrMsg)) != SQLITE_OK)
	{
		std::cout << "SQL error: " << _zErrMsg << std::endl;
		sqlite3_free(_zErrMsg);

		return -1;
	}
	else
	{
		return atoi(_results["game_id"][0].c_str());
	}
}

bool Database::updateGameStatus(int gameId)
{
	clearTable();

	std::stringstream q;
	q << "UPDATE t_games SET status=1, end_time=datetime('now', '+3 hours') WHERE game_id=" << gameId;

	if ((_rc = sqlite3_exec(_db, q.str().c_str(), callback, 0, &_zErrMsg)) != SQLITE_OK)
	{
		std::cout << "SQL error: " << _zErrMsg << std::endl;
		sqlite3_free(_zErrMsg);

		return false;
	}
	else
	{
		return true;
	}
}

bool Database::addAnswerToPlayer(int gameId, std::string username, int questionId, std::string answer, bool isCorrect, int answerTime)
{
	clearTable();

	std::stringstream q;
	q << "INSERT INTO t_players_answers (game_id, username, question_id, player_answer, is_correct, answer_time) VALUES (" << gameId << ", \'" << username << "\', " << questionId << ", \'" << answer << "\', " << isCorrect << ", " << answerTime << ')';

	if ((_rc = sqlite3_exec(_db, q.str().c_str(), callback, 0, &_zErrMsg)) != SQLITE_OK)
	{
		std::cout << "SQL error: " << _zErrMsg << std::endl;
		sqlite3_free(_zErrMsg);

		return false;
	}
	else
	{
		return true;
	}
}
