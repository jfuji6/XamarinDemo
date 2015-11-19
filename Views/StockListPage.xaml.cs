using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinDemo
{
	public partial class StockListPage : ContentPage
	{
		private const string pageTitle = "Stock";
		private StockListViewModel stockListViewModel;

		public StockListPage ()
		{
			InitializeComponent ();
			stockListViewModel = new StockListViewModel();
			BindingContext = stockListViewModel;
			FormButton.Clicked += (sender, e) => Navigation.PushModalAsync (
				new NavigationPage (new FormPage ()));
			StockListView.ItemTapped += StockListView_ItemTapped;
		}

		// Unselect item after being tapped.
		void StockListView_ItemTapped (object sender, ItemTappedEventArgs e)
		{
			StockListView.SelectedItem = null;
		}

		protected override void OnAppearing ()
		{
			base.OnAppearing ();
			var parent = this.Parent as TabbedPage;
			if ( parent != null){
				parent.Title = pageTitle;
			}
		}
	}
}

