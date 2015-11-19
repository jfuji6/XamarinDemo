using System;
using SQLite;

namespace XamarinDemo
{
	public class Stock
	{
		[PrimaryKey, AutoIncrement]
		public int ID { get; set;}
		public string ProductNumber {get; set;}
		public string ProductDescription {get; set;}
		public string LocationName {get; set;}
		public int Quantity {get; set;}
	}
}

