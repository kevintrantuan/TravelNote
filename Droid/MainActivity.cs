﻿using Android.App;
using Android.Content.PM;
using Android.OS;
using Xamarin.Forms;
using Android.Content;
using Android.Graphics;
using Xamarin.Forms.Platform.Android;
using TravelNote.Droid.Dependencies;

namespace TravelNote.Droid
{
	[Activity(Label = "TravelNote.Droid", Icon = "@drawable/TravelNoteIcon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		const int ShareImageId = 1000;

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			Forms.Init(this, bundle);

			LoadApplication(new App());

			MessagingCenter.Subscribe<ImageSource>(this, "Share", Share, null);

		}

		async void Share(ImageSource imageSource)
		{
			var intent = new Intent(Intent.ActionSend);
			intent.SetType("image/png");

			var handler = new ImageLoaderSourceHandler();
			var bitmap = await handler.LoadImageAsync(imageSource, this);

			var path = Environment.GetExternalStoragePublicDirectory(Environment.DirectoryDownloads
				+ Java.IO.File.Separator + "logo.png");

			using (var os = new System.IO.FileStream(path.AbsolutePath, System.IO.FileMode.Create))
			{
				bitmap.Compress(Bitmap.CompressFormat.Png, 100, os);
			}

			intent.PutExtra(Intent.ExtraStream, Android.Net.Uri.FromFile(path));

			var intentChooser = Intent.CreateChooser(intent, "Share via");

			StartActivityForResult(intentChooser, ShareImageId);
		}


		protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
		{
			base.OnActivityResult(requestCode, resultCode, data);

				CameraProvider.OnResult(resultCode);
		}


	}
}

