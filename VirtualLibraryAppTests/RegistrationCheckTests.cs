using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirtualLibraryApp;

namespace VirtualLibraryAppTests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class RegistrationCheckTests
    {
        //public RegistrationCheckTests()
        //{
            //
            // TODO: Add constructor logic here
            //
        //}

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            String firstName = "test1";
            String lastName = "test2";

            String username = "Testas123";
            String password = "Testas123";

            bool allTrue;

            RegistrationWindow registrationWindow = new RegistrationWindow();

            bool resultFN = registrationWindow.CheckFirstName(firstName);
            bool resultLN = registrationWindow.CheckFirstName(lastName);
            bool resultUN = registrationWindow.CheckFirstName(username);
            bool resultPsw = registrationWindow.CheckFirstName(password);

            if (resultFN == resultLN == resultUN == resultPsw == true)
                allTrue = true;
            else
            {
                allTrue = false;
            }

            Assert.IsTrue(allTrue);
        }
    }
}
