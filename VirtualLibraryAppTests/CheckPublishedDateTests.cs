using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;
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
			int date = 2018;
			User user = new User();
			AddBookForm addBook = new AddBookForm(user);

			//Act
			bool result = CheckExtension.CheckPublished(date);

			//Assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void CheckPublishedDate_WithNoInput_ReturnTrue()
		{
			//Arrange
			int date = 0;
			//Act
			bool result = CheckExtension.CheckPublished(date);
			//Assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void CheckPublishedDate_WithWrongInput_ReturnFalse1()
		{
			//Arrange
			int date = 0123;
			//Act
			bool result = CheckExtension.CheckPublished(date);
			//Assert
			Assert.IsFalse(result);
		}

		[TestMethod]
		public void CheckPublishedDate_WithWrongInput_ReturnFalse2()
		{
			//Arrange
			int date = 301;
			//Act
			bool result = CheckExtension.CheckPublished(date);
			//Assert
			Assert.IsFalse(result);
		}
	}
}
