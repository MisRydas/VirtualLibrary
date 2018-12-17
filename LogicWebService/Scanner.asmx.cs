using System;
using System.Threading.Tasks;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Web.Services;
using MessagingToolkit.Barcode;

namespace LogicWebService
{
	/// <summary>
	/// Summary description for Scanner
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
	// [System.Web.Script.Services.ScriptService]
	public class Scanner : System.Web.Services.WebService
	{
		DataTable bookData;

		[WebMethod]
		public void SearchBook(string isbn, ref string error)
		{
			bookData = SQLConnection.GetBookByISBNInDataView(isbn);
			if(bookData == null)
			{
				error += "Book wasn't found";
			}
		}

		[WebMethod]
		public DataTable GetBook(string isbn)
		{
			DataTable books = new DataTable();
			books = SQLConnection.GetBookByISBNInDataView(isbn);
			books.TableName = "Books";
			return books;
		}

		[WebMethod]
		public string GetBookName(string isbn)
		{
			return SQLConnection.GetBookName(isbn);
		}
	}
}
