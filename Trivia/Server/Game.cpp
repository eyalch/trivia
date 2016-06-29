#include "Game.h"
#include "Helper.h"
#include "Protocol.h"
#include <exception>


Game::Game(const std::vector<User*>& players, int questionNo, Database& db) : _db(db), _players(players), _questions_no(questionNo), _currQuestionIndex(0), _isActive(true)
{
	try
	{
		if (insertGameToDB())
		{
			initQuestionsFromDB();

			for (User * &i : _players)
			{
				_results[i->getUsername()] = 0;
				i->setGame(this);
			}
		}
		else
			throw std::exception("Couldn't insert Game into database!");
	}
	catch (const std::exception&)
	{

	}
}

Game::~Game()
{
	for (Question * &i : _questions)
		delete i;

	_questions.clear();
	_players.clear();
}

void Game::handleFinishGame()
{
	_db.updateGameStatus(_gameId);

	std::stringstream s;
	s << END_GAME;
	s << (char)(_players.size() + 48);

	for (User * i : _players)
	{
		std::string name = i->getUsername();
		s << Helper::getPaddedNumber(name.size(), 2);
		s << name;
		s << Helper::getPaddedNumber(_results[name], 2);

		i->setGame(nullptr);
	}

	for (User * i : _players)
	{
		try
		{
			i->send(s.str());
		}
		catch (const std::exception&)
		{

		}
	}

	_isActive = false;
}

bool Game::handleNextTurn()
{
	if (!_players.size())
	{
		handleFinishGame();
		return false;
	}

	if (_isActive)
	{
		if (_currentTurnAnswers == _players.size())
		{
			if (_currQuestionIndex + 1 == _questions_no)
				handleFinishGame();
			else
			{
				_currQuestionIndex++;
				sendQuestionToAllUsers();
			}
		}

		return true;
	}
	else
	{
		return false;
	}
}

bool Game::handleAnswerFromUser(User * user, int answerNo, int time)
{
	if (_isActive)
	{
		_currentTurnAnswers++;

		bool isAnswerRight = answerNo - 1 == _questions[_currQuestionIndex]->getCorrectAnswerIndex();
		
		if (isAnswerRight)
			_results[user->getUsername()]++;

		_db.addAnswerToPlayer(
			_gameId,
			user->getUsername(),
			_questions[_currQuestionIndex]->getId(),
			answerNo == 5 ? "" : _questions[_currQuestionIndex]->getAnswers()[answerNo - 1],
			isAnswerRight,
			time
		);

		std::stringstream s;

		s << IS_CLIENT_CORRECT;
		s << isAnswerRight ? "1" : "0";

		user->send(s.str());

		handleNextTurn();

		return true;
	}
	else
		return false;
}

bool Game::leaveGame(User * currUser)
{
	if (_isActive)
	{
		if (std::find(_players.begin(), _players.end(), currUser) != _players.end())
			_players.erase(std::remove(_players.begin(), _players.end(), currUser), _players.end());

		handleNextTurn();

		return true;
	}
	else
		return false;
}

bool Game::insertGameToDB()
{
	if ((_gameId = _db.insertNewGame()) == -1)
		return false;
	else
		return true;
}

void Game::initQuestionsFromDB()
{
	_questions = _db.initQuestions(_questions_no);
}

void Game::sendQuestionToAllUsers()
{
	_currentTurnAnswers = 0;

	Question * q = _questions[_currQuestionIndex];

	std::stringstream s;

	s << QUESTION;

	std::string str = q->getQuestion();
	if (str.size() > 0)
	{
		s << Helper::getPaddedNumber(str.size(), 3);
		s << str;

		str = q->getAnswers()[0];
		s << Helper::getPaddedNumber(str.size(), 3);
		s << str;

		str = q->getAnswers()[1];
		s << Helper::getPaddedNumber(str.size(), 3);
		s << str;

		str = q->getAnswers()[2];
		s << Helper::getPaddedNumber(str.size(), 3);
		s << str;

		str = q->getAnswers()[3];
		s << Helper::getPaddedNumber(str.size(), 3);
		s << str;
	}
	else
		s << "0";

	if (s.str().size() > 4)
	{
		for (User * i : _players)
		{
			try
			{
				i->send(s.str());
			}
			catch (const std::exception&)
			{

			}
		}
	}
	else
	{
		try
		{
			_players[0]->send(s.str());
		}
		catch (const std::exception&)
		{

		}
	}
}
