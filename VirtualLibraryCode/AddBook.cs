﻿using System;
using CheckExtensions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
	public class AddBook
    {
        public delegate void OnError<T1>(T1 message);
        public delegate void OnSuccess();
        public void Add(string bookName, string isbn13, string isbn10, string author, string genre, string publisher, string published, string listPrice, string coverLink, OnError<String> onError, OnSuccess onSucess)
		{
            string error = "";
            BookItem book = new BookItem();
            if (bookName.Length == 0)
            {
                error += "Book Name is mandatory field\n";
            }
            book.Name = bookName;
            book.ISBN13 = isbn13;
            if (!CheckExtension.CheckISBN13(isbn13))
            {
                error += "Wrong ISBN-13 Code. No spaces, letters, punctuations. ISBN must have 13 numbers\n";
            }
            book.ISBN10 = isbn10;
            if (!CheckExtension.CheckISBN10(isbn10))
            {
                error += "Wrong ISBN-10 Code. No spaces, letters, punctuations. ISBN must have 10 numbers\n";
            }
            if (author.Length == 0)
            {
                error += "Author is mandatory field\n";
            }
            book.Author = author;
            if (genre.Length == 0)
            {
                error += "Genre is mandatory field\n";
            }
            book.Genre = genre;
            book.Publisher = publisher;
            if (!CheckExtension.CheckPublished(published))
            {
                error += "Wrong Published Date format. Example: 2018\n";
            }
            else book.Published = int.Parse(published);
            if (!CheckExtension.CheckListPrice(listPrice))
            {
                error += "Wrong ListPrice format\n";
            }
            else
            {
                double.TryParse(listPrice, out double x);
                book.ListPrice = x;
            }

            book.CoverLink = coverLink;
            if (error.Length == 0)
            {
                SQLConnection.AddNewItem(book);
                onSucess();
            }
            else onError(error);
        }
	}
}
