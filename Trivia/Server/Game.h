#pragma once

#include "Question.h"
#include "User.h"
#include "Database.h"
#include <map>
#include <sstream>
#include <algorithm>

class User;

class Game
{
public:
	Game(const std::vector<User *>& players, int questionNo, Database& db);
	~Game();

	void sendFirstQuestion() { sendQuestionToAllUsers(); }
	void handleFinishGame();
	bool handleNextTurn();
	bool handleAnswerFromUser(User * user, int answerNo, int time);
	bool leaveGame(User * currUser);
	int getID() { return _gameId; }
	
private:
	std::vector<Question *> _questions;
	std::vector<User *> _players;
	int _currQuestionIndex, _currentTurnAnswers, _gameId;
	const int _questions_no;
	bool _isActive;
	Database& _db;
	std::map<std::string, int> _results;

	bool insertGameToDB();
	void initQuestionsFromDB();
	void sendQuestionToAllUsers();
};
