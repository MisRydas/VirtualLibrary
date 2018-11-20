using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace VirtualLibraryAppX
{
    [Activity(Label = "Search Book", Theme = "@style/AppTheme")]
    public class SearchBookActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.searchBookScreen);


			Button searchBookBackButton = FindViewById<Button>(Resource.Id.searchBookBackButton);
			Button searchButton = FindViewById<Button>(Resource.Id.searchButton);

			searchBookBackButton.Click += delegate {
				this.Finish();
			};

			searchButton.Click += delegate {

			};
		}
    }
}