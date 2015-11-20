using System;
using System.Diagnostics;
//using System.ComponentModel;
//using System.Collections.Generic;
using System.Collections.ObjectModel;
//using Xamarin.Forms;


namespace XamarinDemo
{
	public class HobbyListViewModel : BaseViewModel
	{
		public ObservableCollection<Hobby> HobbyList{ get; set;}

		private Hobby _selectedItem;
		public Hobby SelectedItem {
			get {
				return _selectedItem;
			}
			set{
				if (_selectedItem != value){
					_selectedItem = value;
					OnPropertyChanged ();
				}
			}
		}

		public HobbyListViewModel ()
		{
			InitData ();
		}

		private void InitData()
		{
			HobbyList = new ObservableCollection<Hobby> (App.Database.GetHobbies ());
			if (HobbyList.Count < 4) {
				PopulateDatabase ();
			}
		}

		private void PopulateDatabase()
		{
			Hobby hobby = new Hobby {
				Name = "Basketball",
				Blurb = "Watching and playing Hoops!",
				Description = "I like to watch Basketball.  " +
					"I mostly follow NBA games and teams.  " +
					"Although I haven't played in a long time, " +
					"I like to when I find the time.",
				Image = "basketball.png",
				ID = 0
			};
			App.Database.SaveHobby (hobby);
			HobbyList.Add (hobby);

			hobby = new Hobby {
				Name = "Technology",
				Blurb = "Following and exploring new techology.",
				Description = "I like to spend time reading articles " +
					"about new technologies.  I'm particulary interested " +
					"in mobile devices and advancements in automotives.",
				Image = "tech.png",
				ID = 0
			};
		    App.Database.SaveHobby (hobby);
			HobbyList.Add (hobby);

			hobby = new Hobby {
				Name = "DIY",
				Blurb = "Do it Yourself.",
				Description = "I like to spend time reading articles " +
					"about DYI.  I especially like to read about do it " +
					"yourself car audio projects.",
				Image = "diy_icon.png",
				ID = 0
			};
			App.Database.SaveHobby (hobby);
			HobbyList.Add (hobby);

			hobby = new Hobby {
				Name = "Working Out",
				Blurb = "Going to the gymn and staying in shape.",
				Description = "With the demands of work and life I " +
					"I try to stay in shape by going to the gymn " +
					" after work.  I find it is a good way to undwind.",
				Image = "dumbell.png",
				ID = 0
			};
			App.Database.SaveHobby (hobby);
			HobbyList.Add (hobby);
		}
	}
}

