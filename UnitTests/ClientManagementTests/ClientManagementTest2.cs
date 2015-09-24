using Core;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.ClientManagementTests
{
    class ClientManagementTest2
    {
    /// <summary>
    /// Summary description for ClientManagementTest2
    /// </summary>
    [TestClass]
    public class ClientManagementTest2
    {
        public ClientManagementTest2()
        {
            //
            // TODO: Add constructor logic here
            //
        }

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
        public void AddPSDManagerTest()
        {
            ClientManagement.ClientManagementAPI ClientManagementAPI_PSDManager = new ClientManagement.ClientManagementAPI();
            ClientManagementAPI_PSDManager.AddPSDManager(new Core.PSDManager());

            Assert.Fail();
        }
    }
}
