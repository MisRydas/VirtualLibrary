using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
	public class LastSearches
	{
		ILastSearches lastSearchesData;

		public LastSearches(ILastSearches lastSearchesData)
		{
			this.lastSearchesData = lastSearchesData;
			lastSearchesData.LoadSearches += () => GetLastUserSearches();
		}

		public void GetLastUserSearches()
		{
			DataView books = SQLConnection.GetLastSearches(Login.user.Id).AsDataView();
			lastSearchesData.LoadBooks(books);
		}
	}
}
