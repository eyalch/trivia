#include "TriviaServer.h"
#include <iostream>

int main()
{
	try
	{
		TriviaServer server;
		server.serve();
	}
	catch (const std::exception& ex)
	{
		std::cout << ex.what() << std::endl;
	}

	system("pause");
	return 0;
}