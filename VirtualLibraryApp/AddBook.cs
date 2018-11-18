﻿using System;
using Logic;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using CheckExtensions;

delegate void AddingBooks(string bN, string isbn13, string isbn10, string a, string g, string p, string c);
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

            addB(BookNameBox.Text, ISBN13Box.Text, ISBN10Box.Text, AuthorBox.Text, GenreBox.Text, PublisherBox.Text, BookCoverLinkBox.Text);
			MessageBox.Show("Book has been successfully added!");
            this.Close();
		}

		private void Back_Click(object sender, EventArgs e)
		{
            this.Close();
		}

        //delegatai
        private void Add (string bN, string isbn13, string isbn10, string a, string g, string p, string c)
        {
            String bookName = BookNameBox.Text;
            String ISBN13 = ISBN13Box.Text;
            if (!CheckExtension.CheckISBN13(ISBN13))
            {
                MessageBox.Show("Wrong ISBN-13 Code. No spaces, letters, punctuations and code must have 13 numbers. Please correct it.");
                return;
            }
            String ISBN10 = ISBN10Box.Text;
            if (!CheckExtension.CheckISBN10(ISBN10))
            {
                MessageBox.Show("Wrong ISBN-10 Code. No spaces, letters, punctuations and code must have 10 numbers. Please correct it.");
                return;
            }
            String author = AuthorBox.Text;
            String genre = GenreBox.Text;
            String publisher = PublisherBox.Text;
            int.TryParse(PublishedBox.Text, out int published);
            if (!CheckExtension.CheckPublished(published))
            {
                MessageBox.Show("Wrong Published Date format. Please correct it. For example: 2018");
                return;
            }
            double.TryParse(ListPriceBox.Text, out double listPrice);
            String coverLink = BookCoverLinkBox.Text;

            SQLConnection.AddNewBook(bookName, ISBN13, ISBN10, author, genre, publisher, published, listPrice, coverLink);
        }
	}
}
