using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace VirtualLibraryAppX
{
    [Activity(Label = "Last Searches", Theme = "@style/AppTheme")]
    public class LastSearchesActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.lastSearches);


			Button lastSearchesBackButton = FindViewById<Button>(Resource.Id.lastSearchesBackButton);
		//	ImageView lastSearchesBook1 = FindViewById<Button>(Resource.Id.lastSearchesBook1);
		//	Button lastSearchesBook2 = FindViewById<Button>(Resource.Id.lastSearchesBook2);
		//	Button lastSearchesBook3 = FindViewById<Button>(Resource.Id.lastSearchesBook3);

			lastSearchesBackButton.Click += delegate {
				this.Finish();
			};
/*
			lastSearchesBook1.Click += delegate {
				Intent book = new Intent(this, typeof(BookActivity));
				StartActivity(book);
			};

			lastSearchesBook2.Click += delegate {
				Intent book = new Intent(this, typeof(BookActivity));
				StartActivity(book);
			};

			lastSearchesBook3.Click += delegate {
				Intent book = new Intent(this, typeof(BookActivity));
				StartActivity(book);
			};*/
		}
    }
}