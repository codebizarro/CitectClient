using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ctApiWrapper;
using System.Globalization;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ctApiWrapperTest
{
    [TestClass]
    public class MainTest: IDisposable
    {
        string host = "192.168.22.141";
        //string host = "192.168.22.10";
        string user = "kia";
        string pass = "kia";
        int stressCount = 1;
        string tagRead = "SEC15_REG_W1_M151_PV";
        //string tagRead = "REG_14_PV";
        string tagWrite = "DummyStr";
        CitectApi api;

        public MainTest()
        {
            api = new CitectApi(host, user, pass, 0);
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

        //[TestMethod]
        public void OpenBad()
        {
            ctApiWrapper.CitectApi api = new CitectApi("192.168.22.145", "", "", 0);
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
                float f = s.ToFloat();
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
        public void FindScroll()
        {
            for (int i = 0; i < stressCount; ++i)
            {
                Assert.IsFalse(api.Connected);
                api.Open();
                Assert.IsTrue(api.Connected);
                uint obj, obj1, obj2;
                int hFind = api.FindFirst(TableName.Trend, "*", out obj);
                Assert.IsTrue(hFind > 0);
                api.FindScroll(hFind, FindOptions.CT_FIND_SCROLL_LAST, 0, out obj1);
                api.FindScroll(hFind, FindOptions.CT_FIND_SCROLL_FIRST, 0, out obj2);
                api.FindScroll(hFind, FindOptions.CT_FIND_SCROLL_LAST, 0, out obj2);
                Assert.AreEqual(obj1, obj2);
                api.FindScroll(hFind, FindOptions.CT_FIND_SCROLL_PREV, 0, out obj1);
                api.FindScroll(hFind, FindOptions.CT_FIND_SCROLL_PREV, 0, out obj2);
                api.FindScroll(hFind, FindOptions.CT_FIND_SCROLL_NEXT, 0, out obj2);
                Assert.AreEqual(obj1, obj2);
                api.FindScroll(hFind, FindOptions.CT_FIND_SCROLL_RELATIVE, -1, out obj1);
                api.FindScroll(hFind, FindOptions.CT_FIND_SCROLL_RELATIVE, -1, out obj2);
                api.FindScroll(hFind, FindOptions.CT_FIND_SCROLL_RELATIVE, 1, out obj2);
                Assert.AreEqual(obj1, obj2);
                api.FindScroll(hFind, FindOptions.CT_FIND_SCROLL_ABSOLUTE, 2, out obj1);
                api.FindScroll(hFind, FindOptions.CT_FIND_SCROLL_ABSOLUTE, 2, out obj2);
                Assert.AreEqual(obj1, obj2);
                int closeRet = api.FindClose(hFind);
                Assert.IsTrue(closeRet != 0);
                api.Close();
                Assert.IsFalse(api.Connected);
            }
        }

        //[TestMethod]
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

        //[TestMethod]
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
                    string name = api.GetProperty(obj, "NAME", DbType.DBTYPE_STR);
                    lst.Add(tag + " - " + name + " - " + s);
                    //api.Debug = s;
                } while (api.FindNext(hFind, out obj) != 0);


                int closeRet = api.FindClose(hFind);
                Assert.IsTrue(closeRet != 0);
                api.Close();
                Assert.IsFalse(api.Connected);
            }
        }

        [TestMethod]
        public void TrendRead()
        {
            for (int i = 0; i < stressCount; ++i)
            {
                Assert.IsFalse(api.Connected);
                api.Open();
                Assert.IsTrue(api.Connected);
                DateTime endtime = DateTime.Parse("04.06.2015 17:40:00");
                endtime = api.GetDateTime();
                //List<TrendEntry> res1 = api.TrendRead(tagRead, start, 6);
                //Assert.IsTrue(res1.Count > 0);
                List<TrendEntry> res2 = api.TrendRead(tagRead, endtime, endtime.AddMinutes(-30));
                Assert.IsTrue(res2.Count > 0);
                //List<TrendEntryQual> res3 = api.TrendRead(tagRead, start, 6, true, true);
                //Assert.IsTrue(res3.Count > 0);
                List<TrendEntryQual> res4 = api.TrendRead(tagRead, endtime, endtime.AddMinutes(-30), true, false);
                Assert.IsTrue(res4.Count > 0);
                api.Close();
                Assert.IsFalse(api.Connected);
                var all = from a in res2
                          join b in res4 on a.Date equals b.Date
                          select new { a, b };
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.AppendLine("date2;val2;date4;val4");
                foreach (var el in all)
                {
                    string s = string.Format("{0};{1};{2};{3}",
                        el.a.Date, el.b.Value, el.b.Date.ToString("HH:mm:ss"), el.b.Value);
                    sb.AppendLine(s);
                }
                string ret = sb.ToString();
            }
        }

        //[TestMethod]
        public void CheckTrendsEqTags()
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
                    string trendComment = api.GetProperty(obj, "COMMENT", DbType.DBTYPE_STR);
                    uint tobj;
                    int tFind = api.FindFirst(TableName.Tag, tag, out tobj);
                    if (tobj > 0)
                    {
                        string tagComment = api.GetProperty(tobj, "COMMENT", DbType.DBTYPE_STR);
                        Assert.AreEqual(trendComment, tagComment);
                    }

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

        #region IDisposable
        private bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    //component.Dispose();
                    api.Dispose();
                }
                disposed = true;
            }
        }

        ~MainTest()
        {
            Dispose(false);
        }
        #endregion
    }
}
