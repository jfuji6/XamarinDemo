using System;
using System.Collections.Generic;
using System.Linq;

using SQLite;
using Xamarin.Forms;

namespace XamarinDemo
{
	public class SQLiteClient
	{
		readonly SQLite.SQLiteConnection database;

		public SQLiteClient ()
		{
			database = DependencyService.Get<ISQLite> ().GetConnection ();
			database.CreateTable<Hobby> ();
			database.CreateTable<Stock> ();
		}

		#region Hobby
		public IList<Hobby> GetHobbies()
		{
			return database.Table<Hobby> ().ToList ();
		}

		public Hobby GetHobby(int id)
		{
			return database.Table<Hobby> ().Where (hobby => hobby.ID == id).First ();
		}

		public int SaveHobby(Hobby item)
		{
			if (item.ID != 0) {
				return database.Update (item);
			} else {
				return database.Insert (item);
			}
		}

		public int DeleteHobby(Hobby item)
		{
			return this.database.Delete (item);
		}
		#endregion Hobby

		#region Stock
		public IList<Stock> GetStocks()
		{
			return database.Table<Stock> ().ToList ();
		}

		public int SaveStock(Stock item)
		{
			if (item.ID != 0) {
				return database.Update (item);
			} else {
				return database.Insert (item);
			}
		}

		public int DeleteStock(Stock item)
		{
			return this.database.Delete (item);
		}
		#endregion Stock
	}
}

