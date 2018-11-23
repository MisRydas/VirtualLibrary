using System;
using CheckExtensions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
	public class AddBook //Čia yra mūsų Presenter
    {
        public delegate void OnError<T1>(T1 message);
        public delegate void OnSuccess();
        public void Add(IAddBookView view)
		{
            string error = "";
            BookItem book = new BookItem();
            if (view.Name.Length == 0)
            {
                error += "Book Name is mandatory field\n";
            }
            book.Name = view.Name;
            book.ISBN13 = view.ISBN13;
            if (!CheckExtension.CheckISBN13(view.ISBN13))
            {
                error += "Wrong ISBN-13 Code. No spaces, letters, punctuations. ISBN must have 13 numbers\n";
            }
            book.ISBN10 = view.ISBN10;
            if (!CheckExtension.CheckISBN10(view.ISBN10))
            {
                error += "Wrong ISBN-10 Code. No spaces, letters, punctuations. ISBN must have 10 numbers\n";
            }
            if (view.Author.Length == 0)
            {
                error += "Author is mandatory field\n";
            }
            book.Author = view.Author;
            if (view.Genre.Length == 0)
            {
                error += "Genre is mandatory field\n";
            }
            book.Genre = view.Genre;
            book.Publisher = view.Publisher;
            if (!CheckExtension.CheckPublished(view.Published))
            {
                error += "Wrong Published Date format. Example: 2018\n";
            }
            else book.Published = int.Parse(view.Published);
            if (!CheckExtension.CheckListPrice(view.ListPrice))
            {
                error += "Wrong ListPrice format\n";
            }
            else
            {
                double.TryParse(view.ListPrice, out double x);
                book.ListPrice = x;
            }

            book.CoverLink = view.CoverLink;
            if (error.Length == 0)
            {
                SQLConnection.AddNewItem(book);
                view.OnBookAdded();
            }
            else view.OnError(error);
        }
	}
}
