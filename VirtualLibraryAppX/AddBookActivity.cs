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
			EditText name = FindViewById<EditText>(Resource.Id.bookNameTextBox);
			EditText isbn13 = FindViewById<EditText>(Resource.Id.ISBN13TextBox);
			EditText isbn10 = FindViewById<EditText>(Resource.Id.ISBN10TextBox);
			EditText genre = FindViewById<EditText>(Resource.Id.genreTextBox);
			EditText author = FindViewById<EditText>(Resource.Id.authorTextBox);
			EditText publisher = FindViewById<EditText>(Resource.Id.publisherTextBox);
			EditText published = FindViewById<EditText>(Resource.Id.publishedTextBox);
			EditText listPrice = FindViewById<EditText>(Resource.Id.listPriceTextBox);
			EditText coverLink = FindViewById<EditText>(Resource.Id.bookCoverLinkTextBox1);


			addBookBackButton.Click += delegate {
				this.Finish();
			};

			addBookButton.Click += delegate {
				string error = "";

				AddBookService.AddBook client = new AddBookService.AddBook();

				client.Add(ref error, name.Text, isbn13.Text, isbn10.Text, author.Text, publisher.Text, genre.Text, published.Text, listPrice.Text, coverLink.Text);

				if (error.Length == 0)
				{
					this.Finish();
				}
				else
				{
					Toast.MakeText(this, error, ToastLength.Short).Show();
				}
			};
		}
    }
}