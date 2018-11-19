using System;
using CheckExtensions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
	public class AddBookDataProvider
	{
		public bool wrongISBN13;
		public bool wrongISBN10;
		public bool wrongDate;

		public AddBookDataProvider()
		{
			wrongISBN13 = false;
			wrongISBN10 = false;
			wrongDate = false;
		}

		public void ResetData()
		{
			wrongISBN13 = false;
			wrongISBN10 = false;
			wrongDate = false;
		}
	}

	public class AddBook
	{
		public void Add(string bookName, string isbn13, string isbn10, string author, string genre, string publisher, int published, int price, string coverLink, AddBookDataProvider addBookData)
		{
			addBookData.ResetData();
			BookItem book = new BookItem();
			book.Name = bookName;
			book.ISBN13 = isbn13;
			if (!CheckExtension.CheckISBN13(book.ISBN13))
			{
				addBookData.wrongISBN13 = true;
				return;
			}
			book.ISBN10 = isbn13;
			if (!CheckExtension.CheckISBN10(book.ISBN10))
			{
				addBookData.wrongISBN10 = true;
				return;
			}
			book.Author = author;
			book.Genre = genre;
			book.Publisher = publisher;
			book.Published = published;
			if (!CheckExtension.CheckPublished(book.Published.ToString()))
			{
				addBookData.wrongDate = true;
				return;
			}
			book.ListPrice = price;
			book.CoverLink = coverLink;

			SQLConnection.AddNewItem(book);
		}
	}
}
