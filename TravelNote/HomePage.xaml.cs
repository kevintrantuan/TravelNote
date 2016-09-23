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

		async void OnLogin(object sender, EventArgs e)
		{
			if (textLogin.Text != null || textPassword.Text != null)
			{
				if (textLogin.Text.ToUpper() == "A" && textPassword.Text == "a")
				{
					await Navigation.PushAsync(new DiaryPage());
					lblInfo.Text = "";
				}
				else
				{
					lblInfo.Text = "Wrong username or passowrd";
				}
			}
			else
			{
				lblInfo.Text = "Input username and passowrd to login";
			}
		}

		async void OnRegister(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new RegisterPage());
		}

	}
}

