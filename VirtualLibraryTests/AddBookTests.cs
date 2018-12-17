using System;
using LogicWebService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VirtualLibraryTests
{
	[TestClass]
	public class AddBookTests
	{
		AddBook addbook = new AddBook();
		string error = "";

		[TestMethod]
		public void CheckAddBook_WithEmptyName_ReturnError()
		{
			//Arrange
			string name = "";
			string isbn13 = "0123456789123";
			string isbn10 = "0123456789";
			string author = "author";
			string publisher = "publisher";
			string genre = "genre";
			string published = "2018";
			string listPrice = "9.99";
			string coverLink = "google.com";
			string possibleError = "Book Name is mandatory field\n";
			//Act
			addbook.Add(ref error, name, isbn13, isbn10, author, publisher, genre, published, listPrice, coverLink);
			//Assert
			Assert.AreEqual(error, possibleError);
		}

		[TestMethod]
		public void CheckAddBook_WithWrongISBN13_ReturnError()
		{
			//Arrange
			string name = "name";
			string isbn13 = "0123456789123ab";
			string isbn10 = "0123456789";
			string author = "author";
			string publisher = "publisher";
			string genre = "genre";
			string published = "2018";
			string listPrice = "9.99";
			string coverLink = "google.com";
			string possibleError = "Wrong ISBN-13 Code. No spaces, letters, punctuations. ISBN must have 13 numbers\n";
			//Act
			addbook.Add(ref error, name, isbn13, isbn10, author, publisher, genre, published, listPrice, coverLink);
			//Assert
			Assert.AreEqual(error, possibleError);
		}

		[TestMethod]
		public void CheckAddBook_WithWrongISBN10_ReturnError()
		{
			//Arrange
			string name = "name";
			string isbn13 = "0123456789123";
			string isbn10 = "abc";
			string author = "author";
			string publisher = "publisher";
			string genre = "genre";
			string published = "2018";
			string listPrice = "9.99";
			string coverLink = "google.com";
			string possibleError = "Wrong ISBN-10 Code. No spaces, letters, punctuations. ISBN must have 10 numbers\n";
			//Act
			addbook.Add(ref error, name, isbn13, isbn10, author, publisher, genre, published, listPrice, coverLink);
			//Assert
			Assert.AreEqual(error, possibleError);
		}

		[TestMethod]
		public void CheckAddBook_WithWrongDate_ReturnError1()
		{
			//Arrange
			string name = "name";
			string isbn13 = "0123456789123";
			string isbn10 = "0123456789";
			string author = "author";
			string publisher = "publisher";
			string genre = "genre";
			string published = "3333";
			string listPrice = "9.99";
			string coverLink = "google.com";
			string possibleError = "Wrong Published Date format. Example: 2018\n";
			//Act
			addbook.Add(ref error, name, isbn13, isbn10, author, publisher, genre, published, listPrice, coverLink);
			//Assert
			Assert.AreEqual(error, possibleError);
		}

		[TestMethod]
		public void CheckAddBook_WithWrongDate_ReturnError2()
		{
			//Arrange
			string name = "name";
			string isbn13 = "0123456789123";
			string isbn10 = "0123456789";
			string author = "author";
			string publisher = "publisher";
			string genre = "genre";
			string published = "0000";
			string listPrice = "9.99";
			string coverLink = "google.com";
			string possibleError = "Wrong Published Date format. Example: 2018\n";
			//Act
			addbook.Add(ref error, name, isbn13, isbn10, author, publisher, genre, published, listPrice, coverLink);
			//Assert
			Assert.AreEqual(error, possibleError);
		}

		[TestMethod]
		public void CheckAddBook_WithWrongPrice_ReturnError()
		{
			//Arrange
			string name = "name";
			string isbn13 = "0123456789123";
			string isbn10 = "0123456789";
			string author = "author";
			string publisher = "publisher";
			string genre = "genre";
			string published = "2018";
			string listPrice = "2.9ka";
			string coverLink = "google.com";
			string possibleError = "Wrong ListPrice format\n";
			//Act
			addbook.Add(ref error, name, isbn13, isbn10, author, publisher, genre, published, listPrice, coverLink);
			//Assert
			Assert.AreEqual(error, possibleError);
		}
	}
}
