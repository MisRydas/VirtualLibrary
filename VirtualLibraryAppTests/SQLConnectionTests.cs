using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Logic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualLibraryApp.Tests
{
    [TestClass()]
    public class SQLConnectionTests
    {
        [TestMethod()]
        public void GetUserByIdTest()
        {
            User user = new User
            {
                Id = 1,
                UserName = "admin",
                IsAdmin = true
            };
            User userFromDB = SQLConnection.GetUserById(1);
			Assert.IsTrue(user == userFromDB);
		}
		[TestMethod()]
        public void GetUserByIdTest2()
        {
            User user = new User
            {
                Id = 3,
                UserName = "Tomas",
                FirstName = "Tomas",
                LastName = "Ukrinas",
                IsAdmin = true
            };
            User userFromDB = SQLConnection.GetUserById(3);
			Assert.IsTrue(user == userFromDB);
		}
		[TestMethod()]
        public void GetUserByIdTest_ReturnFalse()
        {
            User user = new User
            {
                Id = 1,
                UserName = "admin",
                IsAdmin = true
            };
            User userFromDB = SQLConnection.GetUserById(3);
			Assert.IsTrue(user != userFromDB);
		}
	}
}