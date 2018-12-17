using System;
using LogicWebService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VirtualLibraryTests
{
	[TestClass]
	public class RegistrationTests
	{
		Registration registration = new Registration();
		string error = "";

		[TestMethod]
		public void Registration_WithNonValidPassword_ReturnError()
		{
			//Arrange
			string username = "okis";
			string password = "pokis";
			string cpassword = "pokis";
			string firstname = "vardenis";
			string lastname = "pavardenis";
			string possibleError = "Password must have at least 8 Symbols, 1 lowercase, 1 uppercase and 1 number. Please, correct your password.";
			//Act
			registration.CreateAccount(ref error, username, password, cpassword, firstname, lastname);
			//Assert
			Assert.AreEqual(error, possibleError);
		}

		[TestMethod]
		public void Registration_WithNonValidCPassword_ReturnError()
		{
			//Arrange
			string username = "okis";
			string password = "Pokis123";
			string cpassword = "Pokis321";
			string firstname = "vardenis";
			string lastname = "pavardenis";
			string possibleError = "Passwords do not match";
			//Act
			registration.CreateAccount(ref error, username, password, cpassword, firstname, lastname);
			//Assert
			Assert.AreEqual(error, possibleError);
		}


		[TestMethod]
		public void Registration_WithEmptyFields_ReturnError()
		{
			//Arrange
			string username = "";
			string password = "";
			string cpassword = "";
			string firstname = "";
			string lastname = "";
			string possibleError = "Please fill mandatory fields";
			//Act
			registration.CreateAccount(ref error, username, password, cpassword, firstname, lastname);
			//Assert
			Assert.AreEqual(error, possibleError);
		}
	}
}
