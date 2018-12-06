using Android.App;
using System.Data;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Graphics;
using Java.Net;
using Java.IO;
using System.Net;

namespace VirtualLibraryAppX
{
    [Activity(Label = "Book Information", Theme = "@style/AppTheme")]
    public class BookActivity : AppCompatActivity
    {
		DataTable book;
		string bookNameTxt = "";
		protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.bookScreen);

			ScannerService.Scanner client = new ScannerService.Scanner();
			string isbn = Intent.GetStringExtra("ISBN");

			book = client.GetBook(isbn);
			//bookNameTxt = client.GetBookName(isbn);

			ImageView bookCover = FindViewById<ImageView>(Resource.Id.bookCoverBox);
			TextView bookName = FindViewById<TextView>(Resource.Id.bookNameTextBox);
			TextView isbn13 = FindViewById<TextView>(Resource.Id.bookISBN13);
			TextView isbn10 = FindViewById<TextView>(Resource.Id.bookISBN10);
			TextView author = FindViewById<TextView>(Resource.Id.bookauthor);
			TextView publisher = FindViewById<TextView>(Resource.Id.bookpublisher);
			TextView published = FindViewById<TextView>(Resource.Id.bookpublished);
			TextView listPrice = FindViewById<TextView>(Resource.Id.booklistPrice);

		//	bookName.Text = book.Rows[0]["BookName"].ToString();
			isbn13.Text = book.Rows[0]["ISBN13"].ToString();
			isbn10.Text = book.Rows[0]["ISBN10"].ToString();
			author.Text = book.Rows[0]["Author"].ToString();
			publisher.Text = book.Rows[0]["Publisher"].ToString();
			published.Text = book.Rows[0]["Published"].ToString();
			listPrice.Text = book.Rows[0]["ListPrice"].ToString();

			var cover = GetImageBitmapFromUrl(book.Rows[0]["CoverLink"].ToString());
			bookCover.SetImageBitmap(cover);

			Button bookBackButton = FindViewById<Button>(Resource.Id.bookBackButton);


			bookBackButton.Click += delegate {
				this.Finish();
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