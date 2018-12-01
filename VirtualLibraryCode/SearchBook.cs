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
}
