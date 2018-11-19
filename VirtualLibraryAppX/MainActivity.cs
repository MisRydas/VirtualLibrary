using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace VirtualLibraryAppX
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.loginScreen);


			Button createAccButton = FindViewById<Button>(Resource.Id.createAccButton);
			Button loginButton = FindViewById<Button>(Resource.Id.loginButton);


			createAccButton.Click += delegate {
				SetContentView(Resource.Layout.registrationScreen);
			};

			loginButton.Click += delegate {
				SetContentView(Resource.Layout.mainScreen);
			};
		}
    }
}