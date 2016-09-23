using System;
using Xamarin.Forms;

namespace TravelNote
{
	public partial class ListPage : ContentPage
	{
		public ListPage()
		{
			InitializeComponent();

			NavigationPage.SetHasNavigationBar(this, true);
		}	

		void saveClicked(object sender, EventArgs e)
		{
			var todoItem = (NoteItem)BindingContext;
			Detailhistory.Database.SaveItem(todoItem);
			this.Navigation.PopAsync();
		}

		void deleteClicked(object sender, EventArgs e)
		{
			var todoItem = (NoteItem)BindingContext;
			Detailhistory.Database.DeleteItem(todoItem.ID);
			this.Navigation.PopAsync();
		}

		void cancelClicked(object sender, EventArgs e)
		{
			var todoItem = (NoteItem)BindingContext;
			this.Navigation.PopAsync();
		}

		void speakClicked(object sender, EventArgs e)
		{
			var todoItem = (NoteItem)BindingContext;
			DependencyService.Get<ITextToSpeech>().Speak(todoItem.Name + " " + todoItem.Notes);
		}
	}
}