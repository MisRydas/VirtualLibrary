using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LogicWebService
{
	public class BookInfo
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

	public class Books : IEnumerable
	{
		private BookInfo[] books;

		public Books(String genre)
		{
			DataTable bookData = SQLConnection.GetAllBooksInDataTable();

			var bookInformation = from book in bookData.AsEnumerable() where (book.Field<string>("Genre").IndexOf(genre, StringComparison.OrdinalIgnoreCase) != -1) select book;

			DataTable result = bookInformation.CopyToDataTable();

			books = new BookInfo[result.Rows.Count];

			for (int i = 0; i < result.Rows.Count; i++)
			{
				books[i] = new BookInfo(result.Rows[i]["BookName"].ToString(), result.Rows[i]["CoverLink"].ToString(), result.Rows[i]["ISBN13"].ToString());
			}
		}

		public IEnumerator GetEnumerator()
		{
			return books.GetEnumerator();
		}
	}
}