using System;

using Xamarin.Forms;

namespace XamarinDemo
{
	public class App : Application
	{
		static SQLiteClient _database; 

		public App ()
		{
			// The root page of your application
			MainPage = new NavigationPage (new MainPage ());
		}

		public static SQLiteClient Database {
			get{
				if (_database == null){
					_database = new SQLiteClient ();
				}
				return _database;
			}
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

