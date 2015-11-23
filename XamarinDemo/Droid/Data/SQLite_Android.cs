using System;
using System.IO;
using Xamarin.Forms;
using XamarinDemo;
using XamarinDemo.Droid;

[assembly: Dependency (typeof (SQLite_Android))]
namespace XamarinDemo.Droid
{
	public class SQLite_Android : ISQLite
	{
		public SQLite_Android ()
		{
		}

		public SQLite.SQLiteConnection GetConnection()
		{
			const string sqliteFilename = "XamarinDemo.db3";
			string documentsPath = System.Environment.GetFolderPath 
				(System.Environment.SpecialFolder.Personal);

			var path = Path.Combine (documentsPath, sqliteFilename);

			var conn = new SQLite.SQLiteConnection (path);
			return conn;
		}
	}
}

