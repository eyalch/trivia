#include "Database.h"
#include "sqlite3.h"


Database::Database()
{
	rc = sqlite3_open("Database.db", &db);
	if (rc)
		throw sqlite3_errmsg(db);
}


Database::~Database()
{
	sqlite3_close(db);
}
