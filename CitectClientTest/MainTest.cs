﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Net.CitectClient;

namespace CitectClientTest
{
    [TestClass]
    public class MainTest : IDisposable
    {
        private string host = Configuration.Address;
        private string user = Configuration.User;
        private string pass = Configuration.Password;
        private int stressCount = 1;
        private string tagRead = Configuration.TagRead;
        private string tagWrite = Configuration.TagWrite;
        private readonly ICitectClient _api;

        public MainTest()
        {
            _api = new CitectClient(host, user, pass, 0);
        }

        public string Debug
        {
            set
            {
                System.Diagnostics.Debug.WriteLine(value);
            }
        }

        [TestMethod]
        public void OpenClose()
        {
            for (int i = 0; i < stressCount; ++i)
            {
                Assert.IsFalse(_api.Connected);
                _api.Open();
                Assert.IsTrue(_api.Connected);
                _api.Close();
                Assert.IsFalse(_api.Connected);
            }
        }

        //[TestMethod]
        public void OpenBad()
        {
            CitectClient api = new CitectClient("192.168.22.145", "", "", 0);
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
                Assert.IsFalse(_api.Connected);
                _api.Open();
                Assert.IsTrue(_api.Connected);
                string s = _api.TagRead(tagRead);
                Assert.IsNotNull(s);
                float f = s.ToFloat();
                _api.Close();
                Assert.IsFalse(_api.Connected);
            }
        }

        [TestMethod]
        public void ReadStatus()
        {
            for (int i = 0; i < stressCount; ++i)
            {
                Assert.IsFalse(_api.Connected);
                _api.Open();
                Assert.IsTrue(_api.Connected);
                string s = _api.TagRead(tagRead + ".Status");
                Assert.IsNotNull(s);
                _api.Close();
                Assert.IsFalse(_api.Connected);
            }
        }

        //[TestMethod]
        public void Write()
        {
            for (int i = 0; i < stressCount; ++i)
            {
                Assert.IsFalse(_api.Connected);
                _api.Open();
                Assert.IsTrue(_api.Connected);
                string s = _api.TagRead(tagWrite);
                Assert.IsNotNull(s);
                string sTest = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
                _api.TagWrite(tagWrite, sTest);
                string sTemp = _api.TagRead(tagWrite);
                Assert.IsNotNull(sTemp);
                Assert.AreEqual(sTest, sTemp);
                _api.TagWrite(tagWrite, s);
                _api.Close();
                Assert.IsFalse(_api.Connected);
            }
        }

        [TestMethod]
        public void FindFirst()
        {
            for (int i = 0; i < stressCount; ++i)
            {
                Assert.IsFalse(_api.Connected);
                _api.Open();
                Assert.IsTrue(_api.Connected);
                uint obj;
                int hFind = _api.FindFirst(Tables.Trend.TableName, "*", out obj);
                Assert.IsTrue(hFind > 0);
                int closeRet = _api.FindClose(hFind);
                Assert.IsTrue(closeRet != 0);
                _api.Close();
                Assert.IsFalse(_api.Connected);
            }
        }

        [TestMethod]
        public void FindScroll()
        {
            for (int i = 0; i < stressCount; ++i)
            {
                Assert.IsFalse(_api.Connected);
                _api.Open();
                Assert.IsTrue(_api.Connected);
                uint obj, obj1, obj2;
                int hFind = _api.FindFirst(Tables.Trend.TableName, "*", out obj);
                Assert.IsTrue(hFind > 0);
                _api.FindScroll(hFind, FindOptions.CT_FIND_SCROLL_LAST, 0, out obj1);
                _api.FindScroll(hFind, FindOptions.CT_FIND_SCROLL_FIRST, 0, out obj2);
                _api.FindScroll(hFind, FindOptions.CT_FIND_SCROLL_LAST, 0, out obj2);
                Assert.AreEqual(obj1, obj2);
                _api.FindScroll(hFind, FindOptions.CT_FIND_SCROLL_PREV, 0, out obj1);
                _api.FindScroll(hFind, FindOptions.CT_FIND_SCROLL_PREV, 0, out obj2);
                _api.FindScroll(hFind, FindOptions.CT_FIND_SCROLL_NEXT, 0, out obj2);
                Assert.AreEqual(obj1, obj2);
                _api.FindScroll(hFind, FindOptions.CT_FIND_SCROLL_RELATIVE, -1, out obj1);
                _api.FindScroll(hFind, FindOptions.CT_FIND_SCROLL_RELATIVE, -1, out obj2);
                _api.FindScroll(hFind, FindOptions.CT_FIND_SCROLL_RELATIVE, 1, out obj2);
                Assert.AreEqual(obj1, obj2);
                _api.FindScroll(hFind, FindOptions.CT_FIND_SCROLL_ABSOLUTE, 2, out obj1);
                _api.FindScroll(hFind, FindOptions.CT_FIND_SCROLL_ABSOLUTE, 2, out obj2);
                Assert.AreEqual(obj1, obj2);
                int closeRet = _api.FindClose(hFind);
                Assert.IsTrue(closeRet != 0);
                _api.Close();
                Assert.IsFalse(_api.Connected);
            }
        }

        [TestMethod]
        public void GetAllTags()
        {
            for (int i = 0; i < stressCount; ++i)
            {
                Assert.IsFalse(_api.Connected);
                _api.Open();
                Assert.IsTrue(_api.Connected);
                uint obj;
                int hFind = _api.FindFirst(Tables.Tag.TableName, "*", out obj);
                Assert.IsTrue(hFind > 0);
                ArrayList lst = new ArrayList();
                do
                {
                    string tag = _api.GetProperty(obj, "Tag", DbType.DBTYPE_STR);
                    string s = _api.GetProperty(obj, "FullName", DbType.DBTYPE_STR);
                    string comment = _api.GetProperty(obj, "Comment", DbType.DBTYPE_STR);
                    string add = tag + " - " + s + " - " + comment;
                    lst.Add(add);
                    Debug = add;

                } while (_api.FindNext(hFind, out obj) != 0);

                int closeRet = _api.FindClose(hFind);
                Assert.IsTrue(closeRet != 0);
                _api.Close();
                Assert.IsFalse(_api.Connected);
            }
        }

        [TestMethod]
        public void GetAllTrends()
        {
            for (int i = 0; i < stressCount; ++i)
            {
                Assert.IsFalse(_api.Connected);
                _api.Open();
                Assert.IsTrue(_api.Connected);
                uint obj;
                int hFind = _api.FindFirst(Tables.Trend.TableName, "*", out obj);
                Assert.IsTrue(hFind > 0);
                ArrayList lst = new ArrayList();
                do
                {
                    string tag = _api.GetProperty(obj, "TAG", DbType.DBTYPE_STR);
                    string s = _api.GetProperty(obj, "SAMPLEPER", DbType.DBTYPE_STR);
                    string name = _api.GetProperty(obj, "NAME", DbType.DBTYPE_STR);
                    string comment = _api.GetProperty(obj, "COMMENT", DbType.DBTYPE_STR);
                    string add = tag + " - " + name + " - " + s + " - " + comment;
                    lst.Add(add);
                    Debug = add;
                } while (_api.FindNext(hFind, out obj) != 0);

                int closeRet = _api.FindClose(hFind);
                Assert.IsTrue(closeRet != 0);
                _api.Close();
                Assert.IsFalse(_api.Connected);
            }
        }

        [TestMethod]
        public void TrendRead()
        {
            for (int i = 0; i < stressCount; ++i)
            {
                Assert.IsFalse(_api.Connected);
                _api.Open();
                Assert.IsTrue(_api.Connected);
                DateTime endtime = DateTime.Parse("04.06.2015 17:40:00");
                endtime = _api.GetDateTime();
                //List<TrendEntry> res1 = api.TrendRead(tagRead, start, 6);
                //Assert.IsTrue(res1.Count > 0);
                var res2 = _api.TrendRead(tagRead, endtime, endtime.AddMinutes(-30));
                Assert.IsTrue(res2.Count() > 0);
                //List<TrendEntryQual> res3 = api.TrendRead(tagRead, start, 6, true, true);
                //Assert.IsTrue(res3.Count > 0);
                IEnumerable<TrendEntryQual> res4 = _api.TrendRead(tagRead, endtime, endtime.AddMinutes(-30), true, true);
                Assert.IsTrue(res4.Count() > 0);
                _api.Close();
                Assert.IsFalse(_api.Connected);
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

        [TestMethod]
        public void TrendReadCTAPITrend()
        {
            for (int i = 0; i < stressCount; ++i)
            {
                Assert.IsFalse(_api.Connected);
                _api.Open();
                Assert.IsTrue(_api.Connected);
                DateTime endtime = _api.GetDateTime();
                var res2 = _api.TrendRead(tagRead, endtime, endtime.AddMinutes(-300));
                Assert.IsTrue(res2.Count() > 0);
                _api.Close();
                Assert.IsFalse(_api.Connected);
            }
        }

        [TestMethod]
        public void TrendReadTRNQUERY()
        {
            for (int i = 0; i < stressCount; ++i)
            {
                Assert.IsFalse(_api.Connected);
                _api.Open();
                Assert.IsTrue(_api.Connected);
                DateTime endtime = _api.GetDateTime();
                var res4 = _api.TrendRead(tagRead, endtime, endtime.AddMinutes(-300), true, true);
                Assert.IsTrue(res4.Count() > 0);
                _api.Close();
                Assert.IsFalse(_api.Connected);
            }
        }

        [TestMethod]
        public void GetStaticClassName()
        {
            Assert.IsTrue(Tables.Trend.TableName == "Trend");
            Assert.IsTrue(Tables.Trend.CLUSTER == "CLUSTER");
            Assert.IsTrue(Tables.Trend.NAME == "NAME");
        }

        //[TestMethod]
        public void CheckTrendsEqTags()
        {
            for (int i = 0; i < stressCount; ++i)
            {
                Assert.IsFalse(_api.Connected);
                _api.Open();
                Assert.IsTrue(_api.Connected);
                uint obj;
                int hFind = _api.FindFirst(Tables.Trend.TableName, "*", out obj);
                Assert.IsTrue(hFind > 0);
                ArrayList lst = new ArrayList();
                do
                {
                    string tag = _api.GetProperty(obj, "TAG", DbType.DBTYPE_STR);
                    string trendComment = _api.GetProperty(obj, "COMMENT", DbType.DBTYPE_STR);
                    uint tobj;
                    int tFind = _api.FindFirst(Tables.Tag.TableName, tag, out tobj);
                    if (tobj > 0)
                    {
                        string tagComment = _api.GetProperty(tobj, "COMMENT", DbType.DBTYPE_STR);
                        Assert.AreEqual(trendComment, tagComment);
                    }

                } while (_api.FindNext(hFind, out obj) != 0);

                int closeRet = _api.FindClose(hFind);
                Assert.IsTrue(closeRet != 0);
                _api.Close();
                Assert.IsFalse(_api.Connected);
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

        //[TestMethod]
        public void TrendReadVg1010()
        {
            for (int i = 0; i < stressCount; ++i)
            {
                Assert.IsFalse(_api.Connected);
                _api.Open();
                Assert.IsTrue(_api.Connected);
                DateTime endtime = new DateTime(2015, 10, 6, 23, 50, 0);
                var res4 = _api.TrendRead(tagRead, endtime, endtime.AddHours(-2), true, true);
                Assert.IsTrue(res4.Count() > 0);
                _api.Close();
                Assert.IsFalse(_api.Connected);
            }
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
                    _api.Dispose();
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
