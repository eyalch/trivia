#include "Question.h"
#include <vector>
#include <algorithm>


std::default_random_engine Question::_engine = std::default_random_engine{};

Question::Question(int id, std::string question, std::string correctAnswer, std::string answer2, std::string answer3, std::string answer4) : _id(id), _question(question), _correctAnswer(correctAnswer), _answer2(answer2), _answer3(answer3), _answer4(answer4)
{
	std::vector<std::string> answers({ _correctAnswer, _answer2, _answer3, _answer4 });
	shuffle(answers.begin(), answers.end(), _engine);
	
	_correctIndex = std::find(answers.begin(), answers.end(), _correctAnswer) - answers.begin();
	
	for (int i = 0; i < answers.size(); i++)
		_answers[i] = answers[i];
}


Question::~Question()
{
}
