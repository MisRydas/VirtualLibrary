using System;
using Logic;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace VirtualLibraryApp
{
	public partial class SearchBookForm : Form
	{
		public User user;
		SearchBook searchbook;
		SearchBookDataProvider searchBookData;

		public SearchBookForm(User user)
		{
			InitializeComponent();

			this.user = user;
			searchbook = new SearchBook();
			searchBookData = new SearchBookDataProvider();
		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
			//	SearchB();
			searchbook.Search(SearchTextBox.Text, searchBookData);

			if (searchBookData.missingText)
			{
				MessageBox.Show("Write keyword to find book.");
			}
			else
			{
				DisplayBooks();
			}
		}


		private void bookNameLabel_Click(object sender, EventArgs e)
		{
			searchbook.SelectBook(((Label)sender).Name, user, searchBookData);
			Navigation.OpenBookMenu(this, user, searchBookData.bookData);
		}

		private void bookCoverBox_Click(object sender, EventArgs e)
		{
			searchbook.SelectBook(((PictureBox)sender).Name, user, searchBookData);
			Navigation.OpenBookMenu(this, user, searchBookData.bookData);
		}

		private void Back_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void DisplayBooks()
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
}
