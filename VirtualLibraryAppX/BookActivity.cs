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

namespace VirtualLibraryAppX
{
    [Activity(Label = "Book Information", Theme = "@style/AppTheme")]
    public class BookActivity : AppCompatActivity
    {
		DataTable book;
		protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.bookScreen);

			ScannerService.Scanner client = new ScannerService.Scanner();

			book = client.GetBook();

			ImageView bookCover = FindViewById<ImageView>(Resource.Id.bookCoverBox);
			TextView bookName = FindViewById<TextView>(Resource.Id.bookNameTextBox);
			TextView isbn13 = FindViewById<TextView>(Resource.Id.bookISBN13);
			TextView isbn10 = FindViewById<TextView>(Resource.Id.bookISBN10);
			TextView author = FindViewById<TextView>(Resource.Id.bookauthor);
			TextView publisher = FindViewById<TextView>(Resource.Id.bookpublisher);
			TextView published = FindViewById<TextView>(Resource.Id.bookpublished);
			TextView listPrice = FindViewById<TextView>(Resource.Id.booklistPrice);

			URL url = new URL(book.Rows[0]["bookCover"].ToString());
			Bitmap bmp = BitmapFactory.DecodeStream(url.OpenConnection().InputStream);
			bookCover.SetImageBitmap(bmp);

			bookName.Text = book.Rows[0]["BookName"].ToString();
			isbn13.Text = book.Rows[0]["ISBN13"].ToString();
			isbn10.Text = book.Rows[0]["ISBN10"].ToString();
			author.Text = book.Rows[0]["Author"].ToString();
			publisher.Text = book.Rows[0]["Publisher"].ToString();
			published.Text = book.Rows[0]["Published"].ToString();
			listPrice.Text = book.Rows[0]["ListPrice"].ToString();

			Button bookBackButton = FindViewById<Button>(Resource.Id.bookBackButton);


			bookBackButton.Click += delegate {
				this.Finish();
			};
		}
    }
}