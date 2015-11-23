using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace XamarinDemo
{
	//Base View Model class adds convenience event and method for property changes.
	public class BaseViewModel
	{
		public BaseViewModel ()
		{
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged( [CallerMemberName] string propertyName = null )
		{
			// Saving handler is best practice in case of multi-threading 
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null)
				handler (this, new PropertyChangedEventArgs (propertyName));
		}
	}
}

