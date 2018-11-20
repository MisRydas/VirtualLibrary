using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace VirtualLibraryAppX
{
    [Activity(Label = "Add Book", Theme = "@style/AppTheme")]
    public class AddBookActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.addBookScreen);


			Button addBookBackButton = FindViewById<Button>(Resource.Id.addBookBackButton);
			Button addBookButton = FindViewById<Button>(Resource.Id.addBookButton);


			addBookBackButton.Click += delegate {
				this.Finish();
			};

			addBookButton.Click += delegate {
				this.Finish();
			};
		}
    }
}