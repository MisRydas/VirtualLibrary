using System;
using System.Collections.Generic;
using CheckExtensions;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace LogicWebService
{
	/// <summary>
	/// Summary description for AddBook
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
	// [System.Web.Script.Services.ScriptService]
	public class AddBook : System.Web.Services.WebService
	{
		[WebMethod]
		public void Add(ref string error, string name, string isbn13, string isbn10, string author, string publisher, string genre, string published, string listPrice, string coverLink)
		{
			error = "";
			BookItem book = new BookItem();
			if (name.Length == 0)
			{
				error += "Book Name is mandatory field\n";
			}
			book.Name = name;
			book.ISBN13 = isbn13;
			if (!CheckExtension.CheckISBN13(isbn13))
			{
				error += "Wrong ISBN-13 Code. No spaces, letters, punctuations. ISBN must have 13 numbers\n";
			}
			book.ISBN10 = isbn10;
			if (!CheckExtension.CheckISBN10(isbn10))
			{
				error += "Wrong ISBN-10 Code. No spaces, letters, punctuations. ISBN must have 10 numbers\n";
			}
			if (author.Length == 0)
			{
				error += "Author is mandatory field\n";
			}
			book.Author = author;
			if (genre.Length == 0)
			{
				error += "Genre is mandatory field\n";
			}
			book.Genre = genre;
			book.Publisher = publisher;
			if (!CheckExtension.CheckPublished(published))
			{
				error += "Wrong Published Date format. Example: 2018\n";
			}
			else book.Published = int.Parse(published);
			if (!CheckExtension.CheckListPrice(listPrice))
			{
				error += "Wrong ListPrice format\n";
			}
			else
			{
				double.TryParse(listPrice, out double x);
				book.ListPrice = x;
			}

			book.CoverLink = coverLink;
			if (error.Length == 0)
			{
				SQLConnection.AddNewItem(book);
			}
		}
	}
}
