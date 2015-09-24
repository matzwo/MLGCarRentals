using Core;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.ClientManagementTests
{
    [TestClass]
    public class ClientManagementTest1
    {
        [TestMethod]
        public void AddClientTest()
        {
            ClientManagement.ClientManagementAPI clientManagementAPI_client = new ClientManagement.ClientManagementAPI();
            clientManagementAPI_client.AddClient(new Core.Client());

            Assert.Fail();
        }
    }
}
