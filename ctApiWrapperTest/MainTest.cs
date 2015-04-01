using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ctApiWrapper;
using System.Globalization;

namespace ctApiWrapperTest
{
    [TestClass]
    public class MainTest
    {
        string host = "192.168.22.141";
        string user = "kernel";
        string pass = "citect";
        int stressCount = 10;
        string tag = "SEC15_REG_W1_M151_PV";

        public MainTest()
        {
            CultureInfo customCulture = (CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }

        [TestMethod]
        public void Connection()
        {
            CitectApi ct = new CitectApi(host, user, pass, 0);
            Assert.IsFalse(ct.Connected);
            ct.Connected = true;
            Assert.IsTrue(ct.Connected);
            ct.Connected = false;
            Assert.IsFalse(ct.Connected);
        }

        [TestMethod]
        public void OpenClose()
        {
            CitectApi ct = new CitectApi(host, user, pass, 0);
            for (int i = 0; i < stressCount; ++i)
            {
                Assert.IsFalse(ct.Connected);
                ct.Connected = true;
                Assert.IsTrue(ct.Connected);
                ct.Connected = false;
                Assert.IsFalse(ct.Connected);
            }
        }

        [TestMethod]
        public void CreateWrapper()
        {
            for (int i = 0; i < stressCount; ++i)
            {
                CitectApi ct = new CitectApi(host, user, pass, 0);
                Assert.IsFalse(ct.Connected);
                ct.Connected = true;
                Assert.IsTrue(ct.Connected);
                ct.Connected = false;
                Assert.IsFalse(ct.Connected);
            }
        }

        [TestMethod]
        public void Read()
        {
            for (int i = 0; i < stressCount; ++i)
            {
                CitectApi ct = new CitectApi(host, user, pass, 0);
                Assert.IsFalse(ct.Connected);
                ct.Connected = true;
                Assert.IsTrue(ct.Connected);
                string s = ct.TagRead(tag);
                Assert.IsNotNull(s);
                float f = float.Parse(s);
                ct.Connected = false;
                Assert.IsFalse(ct.Connected);
            }
        }
    }
}
