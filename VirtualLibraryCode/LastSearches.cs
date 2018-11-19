using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
	public class LastSearchesDataProvider
	{
		public string isbn1;
		public string isbn2;
		public string isbn3;
		public DataView bookData;

		public LastSearchesDataProvider()
		{
			isbn1 = "";
			isbn2 = "";
			isbn3 = "";
		}
	}

	public class LastSearches
	{ 
		public void GetLastUserSearches(LastSearchesDataProvider lastSearchesData, User user)
		{
			lastSearchesData.bookData = SQLConnection.GetLastSearches(user.Id).AsDataView();
			lastSearchesData.isbn1 = lastSearchesData.bookData.Count > 0 ? lastSearchesData.bookData[0]["ISBN13"].ToString() : "";
			lastSearchesData.isbn2 = lastSearchesData.bookData.Count > 1 ? lastSearchesData.bookData[1]["ISBN13"].ToString() : "";
			lastSearchesData.isbn3 = lastSearchesData.bookData.Count > 2 ? lastSearchesData.bookData[2]["ISBN13"].ToString() : "";
		}

		public DataView GetBook(string isbn)
		{
			return SQLConnection.GetBookByISBNInDataView(isbn);
		}
	}
}
