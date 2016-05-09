#pragma once

#include <string>
#include <random>

class Question
{
public:
	Question(int id, std::string question, std::string correctAnswer, std::string answer2, std::string answer3, std::string answer4);
	~Question() {}

	std::string getQuestion();  // Returns the question.
	std::string * getAnswers();  // Returns an array of the answers.
	int getCorrectAnswerIndex();  // Returns the index in the answer array which contains the correct answer.
	int getId();  // Returns the ID of the question.

private:
	int _id, _correctAnswerIndex;
	std::string _question, _answers[4];
	static std::default_random_engine _engine;
};

