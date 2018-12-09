using Android.App;
using System.Data;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections.Generic;

namespace VirtualLibraryAppX
{
    [Activity(Label = "Missing Books", Theme = "@style/AppTheme")]
    public class MissingBookActivity : AppCompatActivity
    {
		DataTable books;
		List<string> missingbooks = new List<string>();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.missingBooksScreen);

			Button missingBooksBackButton = FindViewById<Button>(Resource.Id.missingBooksBackButton);

			ListView missingBooksList = FindViewById<ListView>(Resource.Id.listView1);

			MissingBooksService.MissingBooks client = new MissingBooksService.MissingBooks();
			books = client.GetMissingBooks();

			for(int i = 0; i < books.Rows.Count; i++)
			{
				missingbooks.Add("ISBN: " + books.Rows[i][0] + "\nTimes searched: " + books.Rows[i][1] + "\n First searched: " + books.Rows[i][2]);
			}

			ArrayAdapter adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, missingbooks);
			missingBooksList.Adapter = adapter;



			missingBooksBackButton.Click += delegate {
				this.Finish();
			};
		}
    }
}