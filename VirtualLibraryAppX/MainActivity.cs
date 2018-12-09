using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Views;

namespace VirtualLibraryAppX
{
    [Activity(Label = "Main", Theme = "@style/AppTheme")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.mainScreen);

			Button logOutButton = FindViewById<Button>(Resource.Id.logOutButton);
			Button scanISBNButton = FindViewById<Button>(Resource.Id.scanISBNButton);
			Button lastSearchesButton = FindViewById<Button>(Resource.Id.lastSearchesButton);
			Button searchBookButton = FindViewById<Button>(Resource.Id.searchBookButton);
			Button addBookButton = FindViewById<Button>(Resource.Id.addBookButton);
			Button missingBooksButton = FindViewById<Button>(Resource.Id.missingBooksButton);

			bool isAdmin = Intent.GetBooleanExtra("isAdmin", false);

			if(!isAdmin)
			{
				addBookButton.Visibility = ViewStates.Invisible;
				missingBooksButton.Visibility = ViewStates.Invisible;
			}


			logOutButton.Click += delegate {
				this.Finish();
			};

			scanISBNButton.Click += delegate {
				Intent camera = new Intent(this, typeof(CameraActivity));
				StartActivity(camera);
			};

			lastSearchesButton.Click += delegate {
				Intent camera = new Intent(this, typeof(LastSearchesActivity));
				StartActivity(camera);
			};

			searchBookButton.Click += delegate {
				Intent searchBook = new Intent(this, typeof(SearchBookActivity));
				StartActivity(searchBook);
			};

			addBookButton.Click += delegate {
				Intent addBook = new Intent(this, typeof(AddBookActivity));
				StartActivity(addBook);
			};

			missingBooksButton.Click += delegate {
				Intent missingBooks = new Intent(this, typeof(MissingBookActivity));
				StartActivity(missingBooks);
			};
		}
    }
}