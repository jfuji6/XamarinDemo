using System;
using SQLite;

namespace XamarinDemo
{
	public interface ISQLite
	{
		SQLiteConnection GetConnection();
	}
}

