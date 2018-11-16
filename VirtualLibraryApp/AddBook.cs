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
		public AddBook(User User)
		{
			this.User = User;
			InitializeComponent();
		}

		private void AddBookButton_Click(object sender, EventArgs e)
		{
            AddingBooks addB = new AddingBooks(Add);

            addB(BookNameBox.Text, ISBN13Box.Text, ISBN10Box.Text, AuthorBox.Text, GenreBox.Text, PublisherBox.Text, PublishedBox.Text, ListPriceBox.Text, BookCoverLinkBox.Text);
            this.Close();
		}

		private void Back_Click(object sender, EventArgs e)
		{
            this.Close();
		}

        //delegatai
        private void Add (string bookName, string isbn13, string isbn10, string author, string genre, string publisher, string published, string listPrice, string coverLink)
        {
            BookItem book = new BookItem();
            book.Name = bookName;
            book.ISBN13 = isbn13;
            if (!CheckExtension.CheckISBN13(isbn13))
            {
                MessageBox.Show("Wrong ISBN-13 Code. No spaces, letters, punctuations and code must have 13 numbers. Please correct it.");
                return;
            }
            book.ISBN10 = isbn10;
            if (!CheckExtension.CheckISBN10(isbn10))
            {
                MessageBox.Show("Wrong ISBN-10 Code. No spaces, letters, punctuations and code must have 10 numbers. Please correct it.");
                return;
            }
            book.Author = author;
            book.Genre = genre;
            book.Publisher = publisher;
            if (!CheckExtension.CheckPublished(published))
            {
                MessageBox.Show("Wrong Published Date format. Please correct it. For example: 2018");
                return;
            }
            book.Published = int.Parse(published);
            book.ListPrice = double.Parse(listPrice);

            book.CoverLink = coverLink;

            SQLConnection.AddNewItem(book);
            MessageBox.Show("Book has been successfully added!");
        }
    }
}
