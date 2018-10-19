using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace VirtualLibraryApp
{
	public partial class AddBook : Form
	{

		Regex regex;

		public AddBook()
		{
			InitializeComponent();
		}

		private void AddBookButton_Click(object sender, EventArgs e)
		{
			String bookName = BookNameBox.Text;
			String ISBN13 = ISBN13Box.Text;
			regex = new Regex("^[0-9]{13}");
			if(!regex.IsMatch(ISBN13))
			{
				MessageBox.Show("Wrong ISBN-13 Code. No spaces, letters, punctuations and code must have 13 numbers. Please correct it.");
				return;
			}
			String ISBN10 = ISBN10Box.Text;
			regex = new Regex("^[0-9]{10}");
			if (!regex.IsMatch(ISBN10))
			{
				MessageBox.Show("Wrong ISBN-10 Code. No spaces, letters, punctuations and code must have 13 numbers. Please correct it.");
				return;
			}
			String author = AuthorBox.Text;
			String publisher = PublisherBox.Text;
			int.TryParse(PublishedBox.Text, out int published);
			regex = new Regex("^[0-9]{4}");
			if (!regex.IsMatch(published.ToString()))
			{
				MessageBox.Show("Wrong Published Date format. Please correct it. For example: 2018");
				return;
			}
			double.TryParse(ListPriceBox.Text, out double listPrice);
			String coverLink = BookCoverLinkBox.Text;

			SQLConnection.AddNewBook(bookName, ISBN13, ISBN10, author, publisher, published, listPrice, coverLink);

			MessageBox.Show("Book has been successfully added!");
			this.Hide();
			Main mainMenu = new Main(SQLConnection.GetUserById(1));
			mainMenu.Show();
		}
	}
}
