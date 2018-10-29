﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
			AddBook addBook = new AddBook(user);

			//Act
			bool result = addBook.CheckPublished(date);

			//Assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void CheckPublishedDate_WithNoInput_ReturnTrue()
		{
			//Arrange
			int date = 0;
			User user = new User();
			AddBook addBook = new AddBook(user);

			//Act
			bool result = addBook.CheckPublished(date);

			//Assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void CheckPublishedDate_WithWrongInput_ReturnFalse1()
		{
			//Arrange
			int date = 0123;
			User user = new User();
			AddBook addBook = new AddBook(user);

			//Act
			bool result = addBook.CheckPublished(date);

			//Assert
			Assert.IsFalse(result);
		}

		[TestMethod]
		public void CheckPublishedDate_WithWrongInput_ReturnFalse2()
		{
			//Arrange
			int date = 301;
			User user = new User();
			AddBook addBook = new AddBook(user);

			//Act
			bool result = addBook.CheckPublished(date);

			//Assert
			Assert.IsFalse(result);
		}
	}
}