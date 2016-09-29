using Xamarin.Forms;

namespace TravelNote
{
		public class ShareImageViewModel
	{
		public Command Share { get; set; }
		public ImageSource Source { get; set; }

		public ShareImageViewModel()
		{
			Share = new Command(ShareCommand);
		}

		void ShareCommand()
		{
			MessagingCenter.Send<ImageSource>(this.Source, "Share");
		}
	}
}



