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

		public DataView GetMissingBooks()
		{
			DataTable missingBooks = SQLConnection.GetAllMissingBooksISBN();

			return  missingBooks.AsDataView();
		}

	}
}
