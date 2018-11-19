using System;
using Logic;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using CheckExtensions;

namespace VirtualLibraryApp
{
	public partial class AddBookForm : Form
	{
		User user;
		AddBook addBook;
		AddBookDataProvider addBookData;

		public AddBookForm(User user)
		{
			this.user = user;
			InitializeComponent();
			addBook = new AddBook();
			addBookData = new AddBookDataProvider();
		}

		private void AddBookButton_Click(object sender, EventArgs e)
		{
			addBook.Add(BookNameBox.Text, ISBN13Box.Text, ISBN10Box.Text, AuthorBox.Text, GenreBox.Text, 
						PublisherBox.Text, Convert.ToInt32(PublishedBox.Text), Convert.ToInt32(ListPriceBox.Text), 
						BookCoverLinkBox.Text, addBookData);

			if (addBookData.wrongISBN13)
			{
				MessageBox.Show("Wrong ISBN-13 Code. No spaces, letters, punctuations and code must have 13 numbers. Please correct it.");
			}
			else if (addBookData.wrongISBN10)
			{
				MessageBox.Show("Wrong ISBN-10 Code. No spaces, letters, punctuations and code must have 10 numbers. Please correct it.");
			}
			else if (addBookData.wrongISBN10)
			{
				MessageBox.Show("Wrong Published Date format. Please correct it. For example: 2018");
			}
			else
			{
				MessageBox.Show("Book has been successfully added!");
				this.Close();
			}
		}

		private void Back_Click(object sender, EventArgs e)
		{
            this.Close();
		}
	}
}
