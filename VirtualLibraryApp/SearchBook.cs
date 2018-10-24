using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace VirtualLibraryApp
{
	public partial class SearchBook : Form
	{
		public User User;

		public SearchBook(User user)
		{
			InitializeComponent();
			
			this.User = user;
		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(SearchTextBox.Text))
			{
				MessageBox.Show("Write keyword to find book.");
			}
			else
			{
				panel1.Controls.Clear();
				Books searchedBooks = new Books(SearchTextBox.Text);

				int i = 0;

				foreach (BookInfo book in searchedBooks)
				{
					PictureBox bookCoverBox = new PictureBox();
					bookCoverBox.Location = new System.Drawing.Point(20, 15 + (170 * i));
					bookCoverBox.Name = book.ISBN13;
					bookCoverBox.Size = new System.Drawing.Size(90, 130);
					bookCoverBox.SizeMode = PictureBoxSizeMode.StretchImage;
					bookCoverBox.Load(book.coverLink.ToString());
					panel1.Controls.Add(bookCoverBox);
					bookCoverBox.Click += bookCoverBox_Click;
					
					Label bookNameLabel = new Label();
					bookNameLabel.Location = new System.Drawing.Point(115, 10 + (170 * i));
					bookNameLabel.Name = book.ISBN13;
					bookNameLabel.Size = new System.Drawing.Size(450, 80);
					bookNameLabel.Font = new System.Drawing.Font("Calibri", 16);
					bookNameLabel.Text = book.name;
					panel1.Controls.Add(bookNameLabel);
					bookNameLabel.Click += bookNameLabel_Click;
					i++;
				}
			}
		}

		private void bookNameLabel_Click(object sender, EventArgs e)
		{
			this.Hide();
			string isbn = ((Label)sender).Name;
			Book bookMenu = new Book(User, BookInfo(isbn));
			bookMenu.Show();
			SQLConnection.AddISBNToHistory(User.Id, isbn);
		}

		private void bookCoverBox_Click(object sender, EventArgs e)
		{
			this.Hide();
			string isbn = ((PictureBox)sender).Name;
			Book bookMenu = new Book(User, BookInfo(isbn));
			bookMenu.Show();
			SQLConnection.AddISBNToHistory(User.Id, isbn);
		}

		DataView BookInfo(String ISBN13)
		{
			DataTable bookData = SQLConnection.GetAllBooksInDataTable();

			var bookInformation = from book in bookData.AsEnumerable() where book.Field<string>("ISBN13") == ISBN13 select book;

			return bookInformation.AsDataView();
		}

		private void Back_Click(object sender, EventArgs e)
		{
            this.Close();
		}
	}

	class BookInfo
	{
		public BookInfo(string name, string coverLink, string ISBN13)
		{
			this.name = name;
			this.coverLink = coverLink;
			this.ISBN13 = ISBN13;
		}

		public string name;
		public string coverLink;
		public string ISBN13;

	}

	class Books : IEnumerable
	{
		private BookInfo[] books;

		public Books(String genre)
		{
			DataTable bookData = SQLConnection.GetAllBooksInDataTable();

			var bookInformation = from book in bookData.AsEnumerable() where (book.Field<string>("Genre").IndexOf(genre, StringComparison.OrdinalIgnoreCase) != -1) select book;

			DataView result = bookInformation.AsDataView();

			books = new BookInfo[result.Count];

			for(int i = 0; i < result.Count; i++)
			{
				books[i] = new BookInfo(result[i]["BookName"].ToString(), result[i]["CoverLink"].ToString(), result[i]["ISBN13"].ToString());
			}
		}

		public IEnumerator GetEnumerator()
		{
			return books.GetEnumerator();
		}
	}
}
