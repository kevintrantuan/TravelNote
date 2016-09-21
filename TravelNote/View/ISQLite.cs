using System;
using SQLite;

namespace TravelNote
{
	public interface ISQLite
	{
		SQLiteConnection GetConnection();
	}
}