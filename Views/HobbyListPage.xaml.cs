using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinDemo
{
	public partial class HobbyListPage : ContentPage
	{
		private const string pageTitle = "John Fujitani";
		private HobbyListViewModel hobbyListViewModel;

		public HobbyListPage ()
		{
			InitializeComponent ();
			// TODO Should this should be moved to a lifecycle event so that the view is completely constructed 
			// and able to respond to changes?
			hobbyListViewModel = new HobbyListViewModel ();
			BindingContext = hobbyListViewModel;
			HobbyListView.ItemTapped += HobbyListView_ItemTapped;
		}

		void HobbyListView_ItemTapped (object sender, ItemTappedEventArgs e)
		{
			Navigation.PushAsync (new HobbyDetailPage (hobbyListViewModel.SelectedItem ) );
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

