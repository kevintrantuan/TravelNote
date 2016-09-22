using System;
using System.Collections.Generic;
using TravelNote.Views;
using Xamarin.Forms;

namespace TravelNote
{
	public partial class DiaryPage : ContentPage
	{
		public DiaryPage()
		{
			InitializeComponent();
		}

		async void OnMyJourney(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new MyJourney());
		}

		async void OnCamera(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new TakePicturePage ());
		}

		async void OnShare(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new ShareImagePage());
		}

	}
}

