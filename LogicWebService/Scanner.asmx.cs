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
		public DataTable book(string isbn)
		{
			return SQLConnection.GetBookByISBNInDataView(isbn);
		}


		[WebMethod]
		public bool ScanBook(byte[] bookBytes, string error)
		{
			Image x = (Bitmap)((new ImageConverter()).ConvertFrom(bookBytes));
			try
			{
				BarcodeDecoder Scanner = new BarcodeDecoder();
				Result scannerResult = Scanner.Decode((Bitmap)x);

				if (scannerResult.Text.Length == 13)
				{
					CheckISBN(scannerResult.Text, 13, error);
				}
				else if (scannerResult.Text.Length == 10)
				{
					CheckISBN(scannerResult.Text, 10, error);
				}
				else
				{
					error += "Wrong ISBN, please try again.";
				}
			}
			catch (MessagingToolkit.Barcode.NotFoundException)
			{
				error += "Barcode wasn't found.";
			}

			if(error.Length == 0)
			{
				return true;
			}	
			else
			{
				return false;
			}
		}

		public async void CheckISBN(string isbn, int isbnLength, string error)
		{
			await GetBookInDataView(isbn, isbnLength);

			//jei knyga rasta, tai atidarom langa su informacija apie ja, jei knyga nerasta praso ieskoti vel.
			if (bookData.Rows.Count == 0)
			{
				error = "We don't have this book at the moment, please try another one.";
			}
		}

		public Task GetBookInDataView(string isbn, int isbnLength)
		{
			return Task.Factory.StartNew(() =>
			{
				SQLConnection.AddISBNToHistory(Login.user.Id, isbn);

				DataTable bd = SQLConnection.GetAllBooksInDataTable();

				//var bookInformation = from book in bd.AsEnumerable() where book.Field<string>("ISBN" + isbnLength) == isbn select book;
				bookData = SQLConnection.GetBookByISBNInDataView(isbn);
			});
		}

		[WebMethod]
		public DataTable GetBook()
		{
			return bookData;
		}
	}
}
