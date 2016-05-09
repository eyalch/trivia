#pragma once

#include <string>
#include <vector>
#include "Question.h"

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
	int rc;
	sqlite3 * db;
	char * zErrMsg = 0;

	static int callbackCount(void * notUsed, int argc, char ** argv, char ** azCol);
	static int callbackQuestions(void * notUsed, int argc, char ** argv, char ** azCol);
	static int callbackBestScores(void * notUsed, int argc, char ** argv, char ** azCol);
	static int callbackPersonalStatus(void * notUsed, int argc, char ** argv, char ** azCol);
};

