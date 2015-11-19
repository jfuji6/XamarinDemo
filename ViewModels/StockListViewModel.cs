using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;


namespace XamarinDemo
{
	public class StockListViewModel : BaseViewModel
	{
		public ObservableCollection<Stock> StockList{ get; set;}

		public StockListViewModel ()
		{
			InitData ();
		}

		private void InitData()
		{
			StockList = new ObservableCollection<Stock> (App.Database.GetStocks ());
			if (StockList.Count < 3) {
				PopulateDatabase ();
			}
		}

		public void PopulateDatabase()
		{
			Stock stock = new Stock {
				ProductDescription = "Short Product Description",
				LocationName = "San Diego Storage",
				Quantity = 123,
				ProductNumber = "P000012345",
				ID=0

			};
			App.Database.SaveStock (stock);
			StockList.Add (stock);

			stock = new Stock {
				ProductDescription = "Medium Product Description " +
					"Lorem ipsum dolor sit amet, consectetur adipiscing " +
					"elit, sed do eiusmod tempor incididunt ut labore et ",

				LocationName = "San Diego Storage",
				Quantity = 23,
				ProductNumber = "P000067890",
				ID=0				};
			App.Database.SaveStock (stock);
			StockList.Add (stock);

			stock = new Stock {
				ProductDescription = "Long Product Description " +
					"Lorem ipsum dolor sit amet, consectetur adipiscing " +
					"elit, sed do eiusmod tempor incididunt ut labore et " +
					"dolore magna aliqua. Ut enim ad minim veniam, quis " +
					"nostrud exercitation ullamco laboris",
				LocationName = "San Diego Storage",
				Quantity = 1,
				ProductNumber = "P0000223344",
				ID=0				};
			App.Database.SaveStock (stock);
			StockList.Add (stock);
		}
	}
}

