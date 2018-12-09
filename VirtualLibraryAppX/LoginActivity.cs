using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace VirtualLibraryAppX
{
    [Activity(Label = "Virtual Library", Theme = "@style/AppTheme", MainLauncher = true)]
    public class LoginActivity : AppCompatActivity
    {
		bool isAdmin;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.loginScreen);


			Button createAccButton = FindViewById<Button>(Resource.Id.loginCreateAccButton);
			Button loginButton = FindViewById<Button>(Resource.Id.loginButton);


			createAccButton.Click += delegate {
				Intent registration = new Intent(this, typeof(RegistrationActivity));
				StartActivity(registration);
			};

			loginButton.Click += delegate {
				EditText username = FindViewById<EditText>(Resource.Id.loginUsernameTextBox);
				EditText password = FindViewById<EditText>(Resource.Id.loginPasswordTextBox);
				string error = "";
				LoginService.Login client = new LoginService.Login();
				if (client.LoginCheck(username.Text, password.Text, ref error, ref isAdmin))
				{
					Intent main = new Intent(this, typeof(MainActivity));
					main.PutExtra("isAdmin", isAdmin);
					StartActivity(main);
				}
				else
				{
					Toast.MakeText(this, error, ToastLength.Short).Show();
				}
			};
		}
    }
}