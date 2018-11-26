using System;
using System.Data;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{

	public class SearchBook
	{
		DataView bookData;
		ISearchBook searchBookData;

		public SearchBook(ISearchBook searchBookData)
		{
			this.searchBookData = searchBookData;
			searchBookData.SearchButtonPressed += () => Search();
			searchBookData.SelectButtonPressed += () => SelectBook();
		}

		public void Search()
		{
			if (string.IsNullOrEmpty(searchBookData.Input))
			{
				string error = "Write keyword to find book.";
				searchBookData.OnError(error);
			}
			else
			{
				Books searchedBooks = new Books(searchBookData.Input);
				searchBookData.OnBooksFound(searchedBooks);
			}
		}

 		public void SelectBook()
		{
			SQLConnection.AddISBNToHistory(Login.user.Id, searchBookData.ISBN);
			bookData = SQLConnection.GetBookByISBNInDataView(searchBookData.ISBN);
			searchBookData.OnBookSelected(bookData);
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
