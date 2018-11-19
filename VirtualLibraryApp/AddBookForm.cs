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

		public AddBookForm(User user)
		{
			this.user = user;
			InitializeComponent();
			addBook = new AddBook();
		}

		private void AddBookButton_Click(object sender, EventArgs e)
		{
			addBook.Add(BookNameBox.Text, ISBN13Box.Text, ISBN10Box.Text, AuthorBox.Text, GenreBox.Text, 
						PublisherBox.Text, PublishedBox.Text, ListPriceBox.Text, 
						BookCoverLinkBox.Text, out string error);

			if (error.Length != 0)
			{
				MessageBox.Show(error);
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
