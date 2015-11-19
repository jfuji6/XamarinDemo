﻿using System;
using Xamarin.Forms;

namespace XamarinDemo
{
	// This class exposed the bindable property.
	public class DisclosureImageCell : ImageCell
	{
		public static readonly BindableProperty DisclosureProperty =
			BindableProperty.Create<DisclosureImageCell, bool>(p => p.Disclosure, false);

		public bool Disclosure{
			get{ return (bool)base.GetValue (DisclosureProperty); }
			set{ base.SetValue (DisclosureProperty, value); }
		}
			
	}
}

