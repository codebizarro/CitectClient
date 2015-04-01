using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ctApiWrapper;

namespace ctApiWrapperTest
{
    [TestClass]
    public class UnitTestConnection
    {
        [TestMethod]
        public void TestConnection()
        {
            string host = "192.168.22.141";
            string user = "kernel";
            string pass = "citect";
            CitectApi ct = new CitectApi(host, user, pass, 0);
            Assert.IsFalse(ct.Connected);
            ct.Connected = true;
            Assert.IsTrue(ct.Connected);
        }
    }
}
