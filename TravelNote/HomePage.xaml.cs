using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TravelNote
{
	public partial class HomePage : ContentPage
	{
		public HomePage()
		{
			InitializeComponent();
		}

		async void OnRegister(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new RegisterPage());
		}

		async void OnDiary(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new DiaryPage());
		}
	}
}

