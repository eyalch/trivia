#pragma once

#include <string>
#include <random>

class Question
{
public:
	Question(int id, std::string question, std::string correctAnswer, std::string answer2, std::string answer3, std::string answer4);
	~Question();

	std::string _answers[4];
	int _correctIndex;

private:
	int _id;
	std::string _question, _correctAnswer, _answer2, _answer3, _answer4;
	static std::default_random_engine _engine;
};

