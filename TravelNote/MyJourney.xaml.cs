using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TravelNote
{
	public partial class MyJourney : ContentPage
	{
		public MyJourney()
		{
			InitializeComponent();
		}

		async void OnDetail(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new DetailPage());
		}

	}
}

