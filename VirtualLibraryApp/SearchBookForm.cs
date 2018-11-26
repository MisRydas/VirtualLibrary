using System;
using Logic;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace VirtualLibraryApp
{
	public partial class SearchBookForm : Form, ISearchBook
	{
		public event Action SearchButtonPressed;
		public event Action SelectButtonPressed;

		public string Input => SearchTextBox.Text;
		public string ISBN => isbn;
		
		string isbn;

		public SearchBookForm()
		{
			InitializeComponent();
			
		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
			SearchButtonPressed();
		}

		public void OnBooksFound(Books books)
		{
			DisplayBooks(books);
		}

		private void bookNameLabel_Click(object sender, EventArgs e)
		{
			isbn = ((Label)sender).Name;
			SelectButtonPressed();
		}

		private void bookCoverBox_Click(object sender, EventArgs e)
		{
			isbn = ((PictureBox)sender).Name;
			SelectButtonPressed();
		}

		public void OnBookSelected(DataView bookData)
		{
			Navigation.OpenBookMenu(this, bookData, 0);
		}

		public void OnError(string error)
		{
			MessageBox.Show(error);
		}


		private void Back_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void DisplayBooks(Books searchedBooks)
		{
			panel1.Controls.Clear();

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
