#pragma once

#include "Question.h"
#include "User.h"
#include "Database.h"
#include <map>

class Game
{
public:
	Game(const std::vector<User*>& players, int questionNo, Database& db);
	~Game() {}

	void sendFirstQuestion();
	void handleFinishGame();
	bool handleNextTurn();
	bool handleAnswerFromUser(User*, int, int);
	bool leaveGame(User*);
	int getID();

private:
	std::vector<Question> _questions;
	std::vector<User*> _players;
	int _questions_no, _currQuestionIndex, _currentTurnAnswers;
	Database& _db;
	std::map<std::string, int> _results;

	bool insertGameToDB();
	void initQuestionsFromDB();
	void sendQuestionToAllUsers();
};

