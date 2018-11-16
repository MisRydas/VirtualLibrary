using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckExtensions;

namespace VirtualLibraryApp.Tests
{
	[TestClass]
	public class CheckPublishedDateTests
	{
		[TestMethod]
		public void CheckPublishedDate_WithValidInput_ReturnTrue()
		{
			//Arrange
			string date = "2018";
			User user = new User();
			AddBook addBook = new AddBook(user);

			//Act
			bool result = CheckExtension.CheckPublished(date);

			//Assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void CheckPublishedDate_WithNoInput_ReturnFalse()
		{
			//Arrange
			string date = "0";
			//Act
			bool result = CheckExtension.CheckPublished(date);
			//Assert
			Assert.IsFalse(result);
		}

		[TestMethod]
		public void CheckPublishedDate_WithWrongInput_ReturnFalse1()
		{
			//Arrange
			string date = "0123";
			//Act
			bool result = CheckExtension.CheckPublished(date);
			//Assert
			Assert.IsFalse(result);
		}

		[TestMethod]
		public void CheckPublishedDate_WithWrongInput_ReturnFalse2()
		{
			//Arrange
			string date = "301";
			//Act
			bool result = CheckExtension.CheckPublished(date);
			//Assert
			Assert.IsFalse(result);
		}
	}
}
