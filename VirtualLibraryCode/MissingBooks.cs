using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
	public class MissingBooks
	{
		IMissingBooks missingBooksData;

		public MissingBooks(IMissingBooks missingBooksData)
		{
			this.missingBooksData = missingBooksData;
			missingBooksData.LoadMissingBooks += () => GetMissingBooks();

		}

		public void GetMissingBooks()
		{
			DataTable missingBooks = SQLConnection.GetAllMissingBooksISBN();

			missingBooksData.OnMissingBooksFound(missingBooks.AsDataView());
		}
	}
}
