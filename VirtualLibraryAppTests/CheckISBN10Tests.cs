using System;
using VirtualLibraryApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VirtualLibraryApp.Tests
{
	[TestClass]
	public class CheckISBN10Tests
	{
		[TestMethod]
		public void CheckISBN10_WithValidInput_ReturnTrue()
		{
			//Arrange
			string ISBN10 = "0142437239";
			User user = new User();
			AddBook addBook = new AddBook(user);

			//Act
			bool result = addBook.CheckISBN10(ISBN10);

			//Assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void CheckISBN10_WithNoInput_ReturnTrue()
		{
			//Arrange
			string ISBN10 = "";
			User user = new User();
			AddBook addBook = new AddBook(user);

			//Act
			bool result = addBook.CheckISBN10(ISBN10);

			//Assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void CheckISBN10_WithWrongInput_ReturnFalse()
		{
			//Arrange
			string ISBN10 = "123456";
			User user = new User();
			AddBook addBook = new AddBook(user);

			//Act
			bool result = addBook.CheckISBN10(ISBN10);

			//Assert
			Assert.IsFalse(result);
		}
	}
}
