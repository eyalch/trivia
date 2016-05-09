#include "Question.h"
#include <vector>
#include <algorithm>


std::default_random_engine Question::_engine = std::default_random_engine{};

Question::Question(int id, std::string question, std::string correctAnswer, std::string answer2, std::string answer3, std::string answer4) : _id(id), _question(question)
{
	std::vector<std::string> answers({ correctAnswer, answer2, answer3, answer4 });
	shuffle(answers.begin(), answers.end(), _engine);
	
	_correctAnswerIndex = std::find(answers.begin(), answers.end(), correctAnswer) - answers.begin();
	
	for (int i = 0; i < answers.size(); i++)
		_answers[i] = answers[i];
}


std::string Question::getQuestion()
{
	return _question;
}


std::string * Question::getAnswers()
{
	return _answers;
}


int Question::getCorrectAnswerIndex()
{
	return _correctAnswerIndex;
}


int Question::getId()
{
	return _id;
}

