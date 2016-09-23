using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TravelNote
{
	public partial class RegisterPage : ContentPage
	{
		public RegisterPage()
		{
			InitializeComponent();
		}
		async void OnRegister(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new RegisterPage());
		}
		async void OnClear(object sender, EventArgs e)
		{
			textLogin.Text = string.Empty;
			textPassword.Text = string.Empty;
			textConfirmPassword.Text = string.Empty;
			textEmail.Text = string.Empty;
		}
	}
}

