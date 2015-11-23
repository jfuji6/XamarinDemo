using System;
using System.IO;
using XamarinDemo;
using XamarinDemo.iOS;
using Xamarin.Forms;

[assembly: Dependency (typeof ( SQLite_iOS ) ) ]
namespace XamarinDemo.iOS
{
	public class SQLite_iOS : ISQLite
	{
		public SQLite_iOS ()
		{
		}

		public SQLite.SQLiteConnection GetConnection()
		{
			const string sqliteFilename = "XamarinDemo.db3";
			string documentsPath = Environment.GetFolderPath 
				(Environment.SpecialFolder.Personal);
			string libraryPath = Path.Combine (documentsPath, "..", "Library");
			var path = Path.Combine (libraryPath, sqliteFilename);
			var conn = new SQLite.SQLiteConnection (path);
			return conn;

		}
	}
}

