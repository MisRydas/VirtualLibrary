using Android.App;
using System.Data;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Provider;
using Android.Graphics;
using Java.IO;
using System;
using System.Threading;
using ZXing.Mobile;

namespace VirtualLibraryAppX
{
	[Activity(Label = "Camera", Theme = "@style/AppTheme")]
	public class CameraActivity : AppCompatActivity
	{
		ImageView imageView;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.cameraScreen);


			Button cameraBackButton = FindViewById<Button>(Resource.Id.cameraBackButton);
			Button scanButton = FindViewById<Button>(Resource.Id.scanButton);
			imageView = FindViewById<ImageView>(Resource.Id.cameraView);


			cameraBackButton.Click += delegate
			{
				this.Finish();
			};

			scanButton.Click += ScanButton_Click;
		}

		private async void ScanButton_Click(object sender, System.EventArgs e)
		{
			MobileBarcodeScanner.Initialize(Application);

			var scanner = new ZXing.Mobile.MobileBarcodeScanner();

			var result = await scanner.Scan();

			if(result != null)
			{
				string error = "";
				ScannerService.Scanner client = new ScannerService.Scanner();
				client.SearchBook(result.ToString(), error);

				if(error.Length != 0)
				{
					Toast.MakeText(this, error, ToastLength.Short).Show();
				}
				else
				{
					Intent book = new Intent(this, typeof(BookActivity));
					book.PutExtra("ISBN", result.ToString());
					StartActivity(book);
				}

				//	Toast.MakeText(this, result.ToString(), ToastLength.Short).Show();
				/*	string error = "";
					ScannerService.Scanner client = new ScannerService.Scanner();
					client.SearchBook(result.ToString(), error);
					if (error.Length == 0)
					{
						Intent book = new Intent(this, typeof(BookActivity));
						StartActivity(book);
					}
					else
					{
						Toast.MakeText(this, error, ToastLength.Short).Show();
					}*/
			}
		}
		//	Intent intent = new Intent(MediaStore.ActionImageCapture);
		//	StartActivityForResult(intent, 0);
	}
}