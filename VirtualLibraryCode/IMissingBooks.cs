using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
	public interface IMissingBooks
	{
		event Action LoadMissingBooks;

		void OnMissingBooksFound(DataView missingBooksData);
	}
}
