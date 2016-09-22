namespace TravelNote.Views
{
	using TravelNote.Common1;
	using TravelNote.ViewModels;

	using Xamarin.Forms;

	public partial class TakePicturePage : ContentPage
	{
		public TakePicturePage()
		{
			InitializeComponent();

			BindingContext = new TakePictureViewModel(DependencyService.Get<ICameraProvider>());
		}
	}
}

