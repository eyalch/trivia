#include "Game.h"
#include <exception>


Game::Game(const std::vector<User*>& players, int questionNo, Database& db) : _db(db)
{
	try
	{
		_db.insertNewGame();
	}
	catch (std::exception e)
	{
		throw std::exception(e);
	}
	_db.initQuestions(questionNo);
	_players = players;


	for (auto &i : _players)
	{
		_results[i]
	}
}

