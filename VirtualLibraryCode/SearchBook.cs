using System;
using System.Data;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
	public class SearchBookDataProvider
	{
		public bool missingText;
		public DataView bookData;

		public SearchBookDataProvider()
		{
			missingText = false;
		}

		public void ResetData()
		{
			missingText = false;
		}
	}


	public class SearchBook
	{
		public void Search(string input, SearchBookDataProvider searchBookData)
		{
			searchBookData.ResetData();

			if (string.IsNullOrEmpty(input))
			{
				searchBookData.missingText = true;
			}
		}

 		public void SelectBook(string isbn, User user, SearchBookDataProvider searchBookData)
		{
			SQLConnection.AddISBNToHistory(user.Id, isbn);
			searchBookData.bookData = SQLConnection.GetBookByISBNInDataView(isbn);
		}
	}

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

			DataView result = bookInformation.AsDataView();

			books = new BookInfo[result.Count];

			for (int i = 0; i < result.Count; i++)
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
