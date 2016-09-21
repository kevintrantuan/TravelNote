using System;
using System.Collections.Generic;
using MyWeather.View;

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
			await Navigation.PushAsync((Xamarin.Forms.Page)new TodoItemListX());
		}

		async void OnViewWeather(object sender, EventArgs e)
		{
			await Navigation.PushAsync((Xamarin.Forms.Page)new WeatherView());
		}
	}
}

