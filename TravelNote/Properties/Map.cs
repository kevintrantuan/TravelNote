using System;
namespace TravelNote
{
	public class Map: View, IEnumerable<Pin>
	{
		var map = new Map(MapSpan.FromCenterAndRadius(new Position(37, -122), Distance.FromMiles(10)));

		var pin = new Pin()
		{
			Position = new Position(37, -122),
			Label = "Some Pin!"
		};
		map.Pins.Add (pin);

var cp = new ContentPage
{
	Content = map,
};
	}
}

