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
using System.Threading.Tasks;
//using ZXing.Net.Mobile;

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

		private void ScanButton_Click(object sender, System.EventArgs e)
		{
		/*	var scanner = new ZXing.Mobile.MobileBarcodeScanner();

			var result = scanner.Scan();

			if(result != null)
			{
				Toast.MakeText(this, result.ToString(), ToastLength.Short).Show();
			}*/
		}
		//	Intent intent = new Intent(MediaStore.ActionImageCapture);
		//	StartActivityForResult(intent, 0);
	}
}