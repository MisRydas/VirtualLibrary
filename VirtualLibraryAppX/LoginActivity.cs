using Android.App;
using System;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Logic;

namespace VirtualLibraryAppX
{
    [Activity(Label = "Virtual Library", Theme = "@style/AppTheme",MainLauncher = true)]
    public class LoginActivity : AppCompatActivity, ILogin
	{
		public event Action ButtonPressed;

		public string Username => FindViewById<EditText>(Resource.Id.loginUsernameTextBox).Text;
		public string Password => FindViewById<EditText>(Resource.Id.loginPasswordTextBox).Text;

		protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.loginScreen);

			Button createAccButton = FindViewById<Button>(Resource.Id.createAccButton);
			Button loginButton = FindViewById<Button>(Resource.Id.loginButton);

			createAccButton.Click += delegate {
				Intent registration = new Intent(this, typeof(RegistrationActivity));
				StartActivity(registration);
			};

			loginButton.Click += delegate {
				LoginActivity logAct = this;
				Login login = new Login(logAct);
				ButtonPressed();
			};
		}

		public void OnLoginSuccessful()
		{
			Intent main = new Intent(this, typeof(MainActivity));
			StartActivity(main);
		}

		public void OnError(string error)
		{
			Toast.MakeText(this, error, ToastLength.Short).Show();
		}
	}
}