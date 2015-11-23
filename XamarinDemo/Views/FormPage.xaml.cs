using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Text;

namespace XamarinDemo
{
	public partial class FormPage : ContentPage
	{
		//TODO Extrat to resource file.
		private const string alertTitle = "Form Submitted";
		private const string dateFormat = "MM/dd/yyyy";
		private const string switchText = "Switch Enabled: ";
		private const string nameLabel = "Name: ";
		private const string alertButtonText = "OK";

		public FormPage ()
		{
			InitializeComponent ();
			SubmitButton.Clicked += SubmitButton_Clicked;
		}
	
		async void  SubmitButton_Clicked (object sender, EventArgs e)
		{
			StringBuilder sb = new StringBuilder ();
			sb.Append (nameLabel);
			sb.Append (NameEntry.Text);
			sb.Append ("\n");
			sb.Append (FormDatePicker.Date.ToString (dateFormat));
			sb.Append ("\n");
			sb.Append (switchText);
			sb.Append ( ActiveSwitch.IsToggled.ToString() );
			sb.Append ("\n");
			await DisplayAlert(alertTitle, sb.ToString(), alertButtonText);
			await Navigation.PopModalAsync();
		}
	}
}

