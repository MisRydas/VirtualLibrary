using System;
using VirtualLibraryApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VirtualLibraryApp.Tests
{
	[TestClass]
	public class CheckISBN13Tests
	{
		[TestMethod]
		public void CheckISBN13_WithValidInput_ReturnTrue()
		{
			//Arrange
			string ISBN13 = "9780142437230";
			User user = new User();
			AddBook addBook = new AddBook(user);

			//Act
			bool result = addBook.CheckISBN13(ISBN13);

			//Assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void CheckISBN13_WithWrongInput_ReturnFalse()
		{
			//Arrange
			string ISBN13 = "0123456789";
			User user = new User();
			AddBook addBook = new AddBook(user);

			//Act
			bool result = addBook.CheckISBN13(ISBN13);

			//Assert
			Assert.IsFalse(result);
		}
	}
}
