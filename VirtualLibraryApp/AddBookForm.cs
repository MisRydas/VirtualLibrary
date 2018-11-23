using System;
using Logic;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using CheckExtensions;

namespace VirtualLibraryApp
{
    public partial class AddBookForm : Form, IAddBookView//Čia yra mūsų View
    {
        User user;
        AddBook addBook;

        public string ISBN13 => BookNameBox.Text;

        public string ISBN10 => ISBN13Box.Text;

        public string Author => ISBN10Box.Text;

        public string Genre => GenreBox.Text;

        public string Publisher => PublisherBox.Text;

        public string Published => PublishedBox.Text;

        public string ListPrice => ListPriceBox.Text;

        public string CoverLink => BookCoverLinkBox.Text;

        public AddBookForm(User user)
		{
			this.user = user;
			InitializeComponent();
			addBook = new AddBook();
		}

		private void AddBookButton_Click(object sender, EventArgs e)
		{
			addBook.Add(this);
		}

		private void Back_Click(object sender, EventArgs e)
		{
            this.Close();
		}

        public void OnBookAdded()
        {
            MessageBox.Show("Book has been successfully added!");
            this.Close();
        }
        public void OnError(string message)
        {
            MessageBox.Show(message);
        }
    }
}
