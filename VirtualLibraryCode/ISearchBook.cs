using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
	public interface ISearchBook
	{
		event Action SearchButtonPressed;
		event Action SelectButtonPressed;

		string Input { get; }
		string ISBN { get; }
		void OnBooksFound(Books books);
		void OnBookSelected(DataView bookData);
		void OnError(string message);
	}
}
