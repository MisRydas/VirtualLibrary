using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace VirtualLibraryAppX
{
    [Activity(Label = "Missing Books", Theme = "@style/AppTheme")]
    public class MissingBookActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.missingBooksScreen);

			Button missingBooksBackButton = FindViewById<Button>(Resource.Id.missingBooksBackButton);

			missingBooksBackButton.Click += delegate {
				this.Finish();
			};
		}
    }
}