using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using CheckExtensions;

delegate void AddingBooks(string bookName, string isbn13, string isbn10, string author, string genre, string publisher, string published, string listPrice, string coverLink);
namespace VirtualLibraryApp
{
	public partial class AddBook : Form
	{
		User User;
        string error = "";
		public AddBook(User User)
		{
			this.User = User;
			InitializeComponent();
		}

		private void AddBookButton_Click(object sender, EventArgs e)
		{
            AddingBooks addB = new AddingBooks(Add);

            addB(BookNameBox.Text, ISBN13Box.Text, ISBN10Box.Text, AuthorBox.Text, GenreBox.Text, PublisherBox.Text, PublishedBox.Text, ListPriceBox.Text, BookCoverLinkBox.Text);
            if (error.Length == 0)
            {
                MessageBox.Show("Book has been successfully added!");
                this.Close();
            }
            else
                MessageBox.Show(error);
        }

		private void Back_Click(object sender, EventArgs e)
		{
            this.Close();
		}

        //delegatai
        private void Add (string bookName, string isbn13, string isbn10, string author, string genre, string publisher, string published, string listPrice, string coverLink)
        {
            error = "";
            BookItem book = new BookItem();
            if (bookName.Length == 0)
            {
                error += "Book Name is mandatory field\n";
            }
            book.Name = bookName;
            book.ISBN13 = isbn13;
            if (!CheckExtension.CheckISBN13(isbn13))
            {
                error += "Wrong ISBN-13 Code. No spaces, letters, punctuations. ISBN must have 13 numbers\n";
            }
            book.ISBN10 = isbn10;
            if (!CheckExtension.CheckISBN10(isbn10))
            {
                error += "Wrong ISBN-10 Code. No spaces, letters, punctuations. ISBN must have 10 numbers\n";
            }
            if (author.Length == 0)
            {
                error += "Author is mandatory field\n";
            }
            book.Author = author;
            if (genre.Length == 0)
            {
                error += "Genre is mandatory field\n";
            }
            book.Genre = genre;
            book.Publisher = publisher;
            if (!CheckExtension.CheckPublished(published))
            {
                error += "Wrong Published Date format. Example: 2018\n";
            }
            else book.Published = int.Parse(published);
            if (!CheckExtension.CheckListPrice(listPrice))
            {
                error += "Wrong ListPrice format\n";
            }
            else
            {
                double.TryParse(listPrice, out double x);
                book.ListPrice = x;
            }

            book.CoverLink = coverLink;
            if(error.Length == 0)
                SQLConnection.AddNewItem(book);
        }
    }
}
