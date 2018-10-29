using System;
using VirtualLibraryApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckExtentions;

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
			//Act
			bool result = CheckExtention.CheckISBN13(ISBN13);
			//Assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void CheckISBN13_WithWrongInput_ReturnFalse()
		{
			//Arrange
			string ISBN13 = "0123456789";
			//Act
			bool result = CheckExtention.CheckISBN13(ISBN13);
			//Assert
			Assert.IsFalse(result);
		}
	}
}
