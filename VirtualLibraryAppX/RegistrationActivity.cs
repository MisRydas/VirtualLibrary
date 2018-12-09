using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace VirtualLibraryAppX
{
    [Activity(Label = "Registration", Theme = "@style/AppTheme")]
    public class RegistrationActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.registrationScreen);

			Button back = FindViewById<Button>(Resource.Id.registerBackButton);
			EditText firstname = FindViewById<EditText>(Resource.Id.firstNameTextBox);
			EditText lastname = FindViewById<EditText>(Resource.Id.lastNameTextBox);
			EditText username = FindViewById<EditText>(Resource.Id.usernameTextBox);
			EditText password = FindViewById<EditText>(Resource.Id.passwordTextBox);
			EditText cpassword = FindViewById<EditText>(Resource.Id.confirmPasswordTextBox);


			Button register = FindViewById<Button>(Resource.Id.registerButton);

			back.Click += delegate {
				this.Finish();
			};

			register.Click += delegate {
				string error = "";

				RegistrationService.Registration client = new RegistrationService.Registration();
				client.CreateAccount(ref error, username.Text, password.Text, cpassword.Text, firstname.Text, lastname.Text);

				if (error.Length == 0)
				{
					this.Finish();
					Toast.MakeText(this, "Registration successful!", ToastLength.Short).Show();
				}
				else
				{
					Toast.MakeText(this, error, ToastLength.Short).Show();
				}
			};
		}
    }
}