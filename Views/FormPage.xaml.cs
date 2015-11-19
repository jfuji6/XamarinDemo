using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Text;

namespace XamarinDemo
{
	public partial class FormPage : ContentPage
	{
		public const string alertTitle = "Closing Form";
		public FormPage ()
		{
			InitializeComponent ();
			SubmitButton.Clicked += SubmitButton_Clicked;
		}
	
		async void  SubmitButton_Clicked (object sender, EventArgs e)
		{
			StringBuilder sb = new StringBuilder ();
			sb.Append ("Name: ")
			sb.Append (NameEntry.Text);
			sb.Append ("\n");
			sb.Append (FormDatePicker.Date.ToString ("MM/dd/yyyy"));
			sb.Append ("\n");
			sb.Append ("Switch Enabled: ");
			sb.Append ( ActiveSwitch.IsToggled.ToString() );
			sb.Append ("\n");
			await DisplayAlert(alertTitle, sb.ToString(), "Ok");
			await Navigation.PopModalAsync();
		}
	}
}

