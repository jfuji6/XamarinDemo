using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinDemo
{
	public partial class HobbyDetailPage : ContentPage
	{
		private Hobby _hobby;

		public HobbyDetailPage (Hobby hobby)
		{
			InitializeComponent ();
			if(hobby != null){
				_hobby = hobby;
			} else {
				_hobby = new Hobby {
					Name = "N/A",
					Description = "N/A",
					Blurb = "N/A"
				};
			}
			BindingContext = _hobby;
		}
	}
}

