using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ctApiWrapper;
using System.Globalization;
using System.Linq;
using System.Collections;

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
        public void ReadStatus()
        {
            for (int i = 0; i < stressCount; ++i)
            {
                Assert.IsFalse(api.Connected);
                api.Open();
                Assert.IsTrue(api.Connected);
                string s = api.TagRead(tagRead + ".Status");
                Assert.IsNotNull(s);
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

        [TestMethod]
        public void FindFirst()
        {
            for (int i = 0; i < stressCount; ++i)
            {
                Assert.IsFalse(api.Connected);
                api.Open();
                Assert.IsTrue(api.Connected);
                uint obj;
                int hFind = api.FindFirst(TableName.Trend, "*", out obj);
                Assert.IsTrue(hFind > 0);
                int closeRet = api.FindClose(hFind);
                Assert.IsTrue(closeRet != 0);
                api.Close();
                Assert.IsFalse(api.Connected);
            }
        }

        [TestMethod]
        public void GetAllTags()
        {
            for (int i = 0; i < stressCount; ++i)
            {
                Assert.IsFalse(api.Connected);
                api.Open();
                Assert.IsTrue(api.Connected);
                uint obj;
                int hFind = api.FindFirst(TableName.Tag, "*", out obj);
                Assert.IsTrue(hFind > 0);
                ArrayList lst = new ArrayList();
                do
                {
                    string tag = api.GetProperty(obj, "Tag", DbType.DBTYPE_STR);
                    string s = api.GetProperty(obj, "FullName", DbType.DBTYPE_STR);
                    lst.Add(tag + " - " + s);
                } while (api.FindNext(hFind, out obj) != 0);


                int closeRet = api.FindClose(hFind);
                Assert.IsTrue(closeRet != 0);
                api.Close();
                Assert.IsFalse(api.Connected);
            }
        }

        [TestMethod]
        public void GetAllTrends()
        {
            for (int i = 0; i < stressCount; ++i)
            {
                Assert.IsFalse(api.Connected);
                api.Open();
                Assert.IsTrue(api.Connected);
                uint obj;
                int hFind = api.FindFirst(TableName.Trend, "*", out obj);
                Assert.IsTrue(hFind > 0);
                ArrayList lst = new ArrayList();
                do
                {
                    string tag = api.GetProperty(obj, "TAG", DbType.DBTYPE_STR);
                    string s = api.GetProperty(obj, "SAMPLEPER", DbType.DBTYPE_STR);
                    lst.Add(tag + " - " + s);
                    //api.Debug = s;
                } while (api.FindNext(hFind, out obj) != 0);


                int closeRet = api.FindClose(hFind);
                Assert.IsTrue(closeRet != 0);
                api.Close();
                Assert.IsFalse(api.Connected);
            }
        }

        //[TestMethod]
        public void Linq()
        {
            var a = new[] { new { date = "18.05.2015 00:00:05", val = 4 }, new { date = "18.05.2015 00:00:10", val = 1 } };

            var q1 = from n in a
                     orderby n.date
                     select DateTime.Parse(n.date);
            var q2 = a.OrderBy(n => n.date).Select(m => DateTime.Parse(m.date));
            
            Assert.IsTrue(q1.Except(q2).ToArray().Length == 0);
        }
    }
}
