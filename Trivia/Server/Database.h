#pragma once

#include <string>
#include <vector>
#include <unordered_map>
#include "Question.h"
#include "sqlite3.h"

#define DB_NAME "trivia.db"

class Database
{
public:
	Database();
	~Database();

	bool isUserExists(std::string username);  // Check if user exists in database.
	bool addNewUser(std::string username, std::string password, std::string email);  // Add a new user to the database.
	bool isUserAndPassMatch(std::string username, std::string password);  // Check if password matches the username.
	std::vector<Question*> initQuestions(int questionsNo);  // Initialize a list (vector) of random questions.
	std::vector<std::string> getBestScores();  // Returns a list (vector) of the best scores.
	std::vector<std::string> getPersonalStatus(std::string);
	int insertNewGame();  // Add a game to the database with status = 0 and start_time = NOW
	bool updateGameStatus(int gameId);  // Update game status = 1 and end_time = NOW
	bool addAnswerToPlayer(int gameId, std::string username, int questionId, std::string answer, bool isCorrect, int answerTime);  // Add a record to answers table

private:
	int _rc;
	sqlite3* _db;
	char* _zErrMsg = 0;

	static std::unordered_map<std::string, std::vector<std::string>> _results;

	void clearTable();
	static int callback(void* notUsed, int argc, char** argv, char** azCol);
};

