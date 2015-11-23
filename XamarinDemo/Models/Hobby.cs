using System;
using SQLite;

namespace XamarinDemo
{
	public class Hobby
	{
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public string Name { get; set;}
		public string Blurb { get; set;}
		public string Description { get; set;}
		public string Image { get; set; }
	}
}

