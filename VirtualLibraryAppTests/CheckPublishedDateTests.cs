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
			string date = "2018";
			User user = new User();
			AddBookForm addBook = new AddBookForm(user);

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

		[TestMethod]
		public void CheckLstPrice_WithWrongInput_ReturnFalse()
		{
			//Arrange
			string price = "s";
			//Act
			bool result = CheckExtension.CheckListPrice(price);
			//Assert
			Assert.IsFalse(result);
		}
		[TestMethod]
		public void CheckLstPrice_WithWrongInput_ReturnFalse2()
		{
			//Arrange
			string price = ".99";
			//Act
			bool result = CheckExtension.CheckListPrice(price);
			//Assert
			Assert.IsFalse(result);
		}
		[TestMethod]
		public void CheckLstPrice_WithNoInput_ReturnTrue()
		{
			//Arrange
			string price = "";
			//Act
			bool result = CheckExtension.CheckListPrice(price);
			//Assert
			Assert.IsTrue(result);
		}
		[TestMethod]
		public void CheckLstPrice_WithValidInput_ReturnTrue()
		{
			//Arrange
			string price = "0.3";
			//Act
			bool result = CheckExtension.CheckListPrice(price);
			//Assert
			Assert.IsTrue(result);
		}
		[TestMethod]
		public void CheckLstPrice_WithValidInput_ReturnTrue2()
		{
			//Arrange
			string price = "0.33";
			//Act
			bool result = CheckExtension.CheckListPrice(price);
			//Assert
			Assert.IsTrue(result);
		}
		[TestMethod]
		public void CheckLstPrice_WithValidInput_ReturnTrue3()
		{
			//Arrange
			string price = "301";
			//Act
			bool result = CheckExtension.CheckListPrice(price);
			//Assert
			Assert.IsTrue(result);
		}
	}
}
