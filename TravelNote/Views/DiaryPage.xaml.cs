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
			await Navigation.PushAsync((Xamarin.Forms.Page)new TravelNoteList());
		}

		async void OnCamera(object sender, EventArgs e)
		{
			await Navigation.PushAsync((Xamarin.Forms.Page)new TakePicturePage());
		}

		async void OnShare(object sender, EventArgs e)
		{
			await Navigation.PushAsync((Xamarin.Forms.Page)new ShareImagePage());
		}
		async void OnMaps(object sender, EventArgs e)
		{
			//await Navigation.PushAsync((Xamarin.Forms.Page)new MapsPage());

			var tabs = new TabbedPage();

			// demonstrates the map control with zooming and map-types
			tabs.Children.Add(new MapPage { Title = "Map/Zoom", Icon = "glyphish_74_location.png" });

			// demonstrates the map control with zooming and map-types
			tabs.Children.Add(new PinPage { Title = "Pins", Icon = "glyphish_07_map_marker.png" });

			// demonstrates the Geocoder class
			tabs.Children.Add(new GeocoderPage { Title = "Geocode", Icon = "glyphish_13_target.png" });

			// opens the platform's native Map app
			tabs.Children.Add(new MapAppPage { Title = "Map App", Icon = "glyphish_103_map.png" });

			//await MainPage = tabs;
			await Navigation.PushAsync((Xamarin.Forms.Page) tabs);
		}

	}
}

