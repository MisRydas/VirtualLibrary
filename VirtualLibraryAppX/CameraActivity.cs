using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace VirtualLibraryAppX
{
    [Activity(Label = "Camera", Theme = "@style/AppTheme")]
    public class CameraActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.cameraScreen);


			Button cameraBackButton = FindViewById<Button>(Resource.Id.cameraBackButton);
			Button scanButton = FindViewById<Button>(Resource.Id.scanButton);


			cameraBackButton.Click += delegate {
				this.Finish();
			};

			scanButton.Click += delegate {
				Intent book = new Intent(this, typeof(BookActivity));
				StartActivity(book);
			};
		}
    }
}