using Android.App;
using System.Data;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Graphics;
using System.Net;

namespace VirtualLibraryAppX
{
    [Activity(Label = "Last Searches", Theme = "@style/AppTheme")]
    public class LastSearchesActivity : AppCompatActivity
    {

		DataTable books;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.lastSearches);


			Button lastSearchesBackButton = FindViewById<Button>(Resource.Id.lastSearchesBackButton);
			ImageView lastSearchesBook1 = FindViewById<ImageView>(Resource.Id.lastSearchesBook1);
			ImageView lastSearchesBook2 = FindViewById<ImageView>(Resource.Id.lastSearchesBook2);
			ImageView lastSearchesBook3 = FindViewById<ImageView>(Resource.Id.lastSearchesBook3);

			LastSearchesService.LastSearches client = new LastSearchesService.LastSearches();
			books = client.GetLastUserSearches();

			if (books.Rows[0]["CoverLink"] != null)
			{
				var cover = GetImageBitmapFromUrl(books.Rows[0]["CoverLink"].ToString());
				lastSearchesBook1.SetImageBitmap(cover);
			}

			if (books.Rows[1]["CoverLink"] != null)
			{
				var cover = GetImageBitmapFromUrl(books.Rows[1]["CoverLink"].ToString());
				lastSearchesBook2.SetImageBitmap(cover);
			}

			if (books.Rows[2]["CoverLink"] != null)
			{
				var cover = GetImageBitmapFromUrl(books.Rows[2]["CoverLink"].ToString());
				lastSearchesBook3.SetImageBitmap(cover);
			}

			lastSearchesBackButton.Click += delegate {
				this.Finish();
			};

			lastSearchesBook1.Click += delegate {
				Intent book = new Intent(this, typeof(BookActivity));
				book.PutExtra("ISBN", books.Rows[0]["ISBN13"].ToString());
				StartActivity(book);
			};
			
			lastSearchesBook2.Click += delegate {
				Intent book = new Intent(this, typeof(BookActivity));
				book.PutExtra("ISBN", books.Rows[1]["ISBN13"].ToString());
				StartActivity(book);
			};

			lastSearchesBook3.Click += delegate {
				Intent book = new Intent(this, typeof(BookActivity));
				book.PutExtra("ISBN", books.Rows[2]["ISBN13"].ToString());
				StartActivity(book);
			};
		}

		private Bitmap GetImageBitmapFromUrl(string url)
		{
			Bitmap imageBitmap = null;

			using (var webClient = new WebClient())
			{
				var imageBytes = webClient.DownloadData(url);
				if (imageBytes != null && imageBytes.Length > 0)
				{
					imageBitmap = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
				}
			}

			return imageBitmap;
		}
	}
}