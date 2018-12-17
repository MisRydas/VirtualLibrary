using System;
using LogicWebService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VirtualLibraryTests
{
	[TestClass]
	public class LoginTests
	{
		[TestMethod]
		public void Login_WithValidInput_ReturnTrue()
		{
			//Arrange
			Login login = new Login();
			string username = "admin";
			string password = "administrator";
			string error = "";
			bool isAdmin = false;
			//Act
			bool result = login.LoginCheck(username, password,ref error, ref isAdmin);
			//Assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void Login_WithNonValidInput_ReturnFalse()
		{
			//Arrange
			Login login = new Login();
			string username = "ad";
			string password = "ad";
			string error = "";
			bool isAdmin = false;
			//Act
			bool result = login.LoginCheck(username, password, ref error, ref isAdmin);
			//Assert
			Assert.IsFalse(result);
		}

		[TestMethod]
		public void Login_WithAdminInput_ReturnIsAdminTrue()
		{
			//Arrange
			Login login = new Login();
			string username = "admin";
			string password = "administrator";
			string error = "";
			bool isAdmin = false;
			//Act
			bool result = login.LoginCheck(username, password, ref error, ref isAdmin);
			//Assert
			Assert.IsTrue(isAdmin);
		}

		[TestMethod]
		public void Login_WithNonAdminInput_ReturnIsAdminFalse()
		{
			//Arrange
			Login login = new Login();
			string username = "yo";
			string password = "yo";
			string error = "";
			bool isAdmin = false;
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
			string error = "";
			bool isAdmin = false;
			//Act
			bool result = login.LoginCheck(username, password, ref error, ref isAdmin);
			//Assert
			Assert.AreEqual(error, possibleError);
		}
	}
}
