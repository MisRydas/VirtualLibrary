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
			Button register = FindViewById<Button>(Resource.Id.registerButton);

			back.Click += delegate {
				this.Finish();
			};

			register.Click += delegate {
				this.Finish();
			};
		}
    }
}