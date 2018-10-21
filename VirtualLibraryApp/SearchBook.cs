using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace VirtualLibraryApp
{
	public partial class SearchBook : Form
	{
		//	public User User { get; set; }

		public SearchBook()
		{
			InitializeComponent();
			BookCover.Hide();
			BookName.Hide();
			//		this.User = user;
		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(SearchTextBox.Text))
			{
				MessageBox.Show("Write keyword to find book.");
			}
			else
			{
				Books searchedBooks = new Books(SearchTextBox.Text);

				int i = 0;


				foreach (BookInfo book in searchedBooks)
				{
					PictureBox bookCover = BookCover;
					LinkLabel bookName = BookName;
					BookCover.Load(book.coverLink.ToString());
					bookName.Text = book.name;
					bookCover.Name = book.ISBN13;
					bookName.Name = book.ISBN13;
					bookCover.Location = new System.Drawing.Point(30, 15 + (170 * i));
					bookName.Location = new System.Drawing.Point(130, 15 + (170 * i));
					bookCover.Show();
					bookName.Show();
					i++;
				}
			}
		}

		private void BookCover_Click(object sender, EventArgs e)
		{
			this.Hide();
			Book bookMenu = new Book(BookInfo(BookName.Name));
			bookMenu.Show();
			//	SQLConnection.AddISBNToHistory(User.Id, isbn);
		}

		DataView BookInfo(String ISBN13)
		{
			DataTable bookData = SQLConnection.SelectQuery("SELECT * FROM Books");

			var bookInformation = from book in bookData.AsEnumerable() where book.Field<string>("ISBN13") == ISBN13 select book;

			return bookInformation.AsDataView();
		}

		private void BookName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Hide();
			Book bookMenu = new Book(BookInfo(BookName.Name));
			bookMenu.Show();
			//	SQLConnection.AddISBNToHistory(User.Id, isbn);
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

		public Books(String ISBN13)
		{
			DataTable bookData = SQLConnection.SelectQuery("SELECT BookName, CoverLink, ISBN13 FROM Books WHERE ISBN13 =\"" + ISBN13 + "\";");

			DataView result = bookData.AsDataView();

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
