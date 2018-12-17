using System;
using LogicWebService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VirtualLibraryTests
{
	[TestClass]
	public class LoginTests
	{
		Login login = new Login();
		string error = "";
		bool isAdmin = false;

		[TestMethod]
		public void Login_WithValidInput_ReturnTrue()
		{
			//Arrange
			string username = "admin";
			string password = "administrator";
			//Act
			bool result = login.LoginCheck(username, password,ref error, ref isAdmin);
			//Assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void Login_WithNonValidInput_ReturnFalse()
		{
			//Arrange
			string username = "ad";
			string password = "ad";
			//Act
			bool result = login.LoginCheck(username, password, ref error, ref isAdmin);
			//Assert
			Assert.IsFalse(result);
		}

		[TestMethod]
		public void Login_WithAdminInput_ReturnIsAdminTrue()
		{
			//Arrange
			string username = "admin";
			string password = "administrator";
			//Act
			bool result = login.LoginCheck(username, password, ref error, ref isAdmin);
			//Assert
			Assert.IsTrue(isAdmin);
		}

		[TestMethod]
		public void Login_WithNonAdminInput_ReturnIsAdminFalse()
		{
			//Arrange
			string username = "yo";
			string password = "yo";
			//Act
			bool result = login.LoginCheck(username, password, ref error, ref isAdmin);
			//Assert
			Assert.IsFalse(isAdmin);
		}

		[TestMethod]
		public void Login_WithNonValidInput_ReturnIsWrongCreditials()
		{
			//Arrange
			Login login = new Login();
			string username = "ad";
			string password = "ad";
			string possibleError = "Wrong username or password";
			//Act
			bool result = login.LoginCheck(username, password, ref error, ref isAdmin);
			//Assert
			Assert.AreEqual(error, possibleError);
		}
	}
}
