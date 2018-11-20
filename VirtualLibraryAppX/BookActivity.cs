using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace VirtualLibraryAppX
{
    [Activity(Label = "Book Information", Theme = "@style/AppTheme")]
    public class BookActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.bookScreen);


			Button createAccButton = FindViewById<Button>(Resource.Id.bookBackButton);


			createAccButton.Click += delegate {
				this.Finish();
			};
		}
    }
}