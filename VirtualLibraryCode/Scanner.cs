using DarrenLee.Media;
using System;
using System.Data;
using System.Collections.Generic;
using MessagingToolkit.Barcode;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Logic
{
	public class Scanner
	{
		DataView bookData;
		IScanner scannerData;

		public Scanner(IScanner scannerData)
		{
			this.scannerData = scannerData;
			scannerData.ButtonPressed += () => ScanBook();
		}

		public void ScanBook()
		{
			string error = "";

			try
			{
				BarcodeDecoder Scanner = new BarcodeDecoder();
				Result scannerResult = Scanner.Decode(new Bitmap(scannerData.BookImage));

				if (scannerResult.Text.Length == 13)
				{
					CheckISBN(scannerResult.Text, 13);
				}
				else if (scannerResult.Text.Length == 10)
				{
					CheckISBN(scannerResult.Text, 10);
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
			if(error.Length != 0)
			{
				scannerData.OnError(error);
			}
		}
		
		public async void CheckISBN(string isbn, int isbnLength)
		{
			await GetBookInDataView(isbn, isbnLength);

			//jei knyga rasta, tai atidarom langa su informacija apie ja, jei knyga nerasta praso ieskoti vel.
			if (bookData.Count == 0)
			{
				string error = "We don't have this book at the moment, please try another one.";
				scannerData.OnError(error);
			}
			else
			{
				scannerData.OnBookFound(bookData);
			}
		}

		public Task GetBookInDataView(string isbn, int isbnLength)
		{
			return Task.Factory.StartNew(() =>
			{
				SQLConnection.AddISBNToHistory(Login.user.Id, isbn);

				DataTable bd = SQLConnection.GetAllBooksInDataTable();

				var bookInformation = from book in bd.AsEnumerable() where book.Field<string>("ISBN" + isbnLength) == isbn select book;

				bookData = bookInformation.AsDataView();
			});
		}
	}
}
