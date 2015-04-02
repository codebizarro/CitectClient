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
        string user = "kia";
        string pass = "kia";
        int stressCount = 1;
        string tagRead = "SEC15_REG_W1_M151_PV";
        string tagWrite = "DummyStr";
        CitectApi api;

        public MainTest()
        {
            CultureInfo customCulture = (CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            api = new CitectApi(host, user, pass, 0);
        }

        [TestMethod]
        public void Connection()
        {
            Assert.IsFalse(api.Connected);
            api.Open();
            Assert.IsTrue(api.Connected);
            api.Close();
            Assert.IsFalse(api.Connected);
        }

        [TestMethod]
        public void OpenClose()
        {
            for (int i = 0; i < stressCount; ++i)
            {
                Assert.IsFalse(api.Connected);
                api.Open();
                Assert.IsTrue(api.Connected);
                api.Close();
                Assert.IsFalse(api.Connected);
            }
        }

        [TestMethod]
        public void Read()
        {
            for (int i = 0; i < stressCount; ++i)
            {
                Assert.IsFalse(api.Connected);
                api.Open();
                Assert.IsTrue(api.Connected);
                string s = api.TagRead(tagRead);
                Assert.IsNotNull(s);
                float f = float.Parse(s);
                api.Close();
                Assert.IsFalse(api.Connected);
            }
        }

        [TestMethod]
        public void Write()
        {
            for (int i = 0; i < stressCount; ++i)
            {
                Assert.IsFalse(api.Connected);
                api.Open();
                Assert.IsTrue(api.Connected);
                string s = api.TagRead(tagWrite);
                Assert.IsNotNull(s);
                string sTest = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
                api.TagWrite(tagWrite, sTest);
                string sTemp = api.TagRead(tagWrite);
                Assert.IsNotNull(sTemp);
                Assert.AreEqual(sTest, sTemp);
                api.TagWrite(tagWrite, s);
                api.Close();
                Assert.IsFalse(api.Connected);
            }
        }
    }
}
