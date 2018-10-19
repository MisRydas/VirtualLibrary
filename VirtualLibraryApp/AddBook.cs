using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualLibraryApp
{
	public partial class AddBook : Form
	{
		public AddBook()
		{
			InitializeComponent();
		}

		private void AddBookButton_Click(object sender, EventArgs e)
		{
			String bookName = BookNameBox.Text;
			String ISBN13 = ISBN13Box.Text;
			String ISBN10 = ISBN10Box.Text;
			String author = AuthorBox.Text;
			String publisher = PublisherBox.Text;
			int.TryParse(PublishedBox.Text, out int published);
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
