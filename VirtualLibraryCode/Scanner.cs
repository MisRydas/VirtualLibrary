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

	public class ScannerDataProvider
	{
		public bool wrongCode;
		public bool bookNotFound;
		public bool barcodeNotFound;
		public string isbn;
		public DataView bookData;

		public ScannerDataProvider()
		{
			wrongCode = false;
			bookNotFound = false;
			barcodeNotFound = false;
		}

		public void ResetData()
		{
			wrongCode = false;
			bookNotFound = false;
			barcodeNotFound = false;
		}
	}

	public class Scanner
	{

		public void ScanBook(Image bookImage, ScannerDataProvider scannerData, User user)
		{
			scannerData.ResetData();

			try
			{
				BarcodeDecoder Scanner = new BarcodeDecoder();
				Result scannerResult = Scanner.Decode(new Bitmap(bookImage));

				scannerData.isbn = scannerResult.Text;

				if (scannerResult.Text.Length == 13)
				{
					CheckISBN(scannerResult.Text, 13, scannerData, user);
				}
				else if (scannerResult.Text.Length == 10)
				{
					CheckISBN(scannerResult.Text, 10, scannerData, user);
				}
				else
				{
					scannerData.wrongCode = true;
				}
			}
			catch (MessagingToolkit.Barcode.NotFoundException)
			{
				scannerData.barcodeNotFound = true;
			}
		}
		
		public async void CheckISBN(string isbn, int isbnLength, ScannerDataProvider scannerData, User user)
		{
			await GetBookInDataView(isbn, isbnLength, scannerData, user);

			//jei knyga rasta, tai atidarom langa su informacija apie ja, jei knyga nerasta praso ieskoti vel.
			if (scannerData.bookData.Count == 1)
			{
				scannerData.bookNotFound = true;
			}
		}

		public Task GetBookInDataView(string isbn, int isbnLength, ScannerDataProvider scannerData, User user)
		{
			return Task.Factory.StartNew(() =>
			{
				SQLConnection.AddISBNToHistory(user.Id, isbn);

				DataTable bookData = SQLConnection.GetAllBooksInDataTable();

				var bookInformation = from book in bookData.AsEnumerable() where book.Field<string>("ISBN" + isbnLength) == isbn select book;

				scannerData.bookData = bookInformation.AsDataView();
			});
		}
	}
}
