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
		public void Add(string mbookName, string misbn13, string misbn10, string mauthor, string mgenre, string mpublisher, int mpublished, int mprice, string mcoverLink, AddBookDataProvider addBookData)
		{
			addBookData.ResetData();
			String bookName = mbookName;
			String ISBN13 = misbn13;
			if (!CheckExtension.CheckISBN13(ISBN13))
			{
				addBookData.wrongISBN13 = true;
				return;
			}
			String ISBN10 = misbn13;
			if (!CheckExtension.CheckISBN10(ISBN10))
			{
				addBookData.wrongISBN10 = true;
				return;
			}
			String author = mauthor;
			String genre = mgenre;
			String publisher = mpublisher;
			int published = mpublished;
			if (!CheckExtension.CheckPublished(published))
			{
				addBookData.wrongDate = true;
				return;
			}
			int listPrice = mprice;
			String coverLink = mcoverLink;

			SQLConnection.AddNewBook(bookName, ISBN13, ISBN10, author, genre, publisher, published, listPrice, coverLink);
		}
	}
}
