using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ctApiWrapper
{
    static class CtApiTrend
    {
        /// <summary>
        /// Query string builder.
        /// </summary>
        /// <param name="tag">The trend tag name for the data to be searched.</param>
        /// <param name="datetime">The starting time for the trend. Set the time to an empty string to search the latest trend samples. The date of the trend.</param>
        /// <param name="period">The period (in seconds) that you want to search (this period can differ from the actual trend period). The Period argument used in the CTAPITrend() function needs to be 0 (zero) when this function is used as an argument to ctFindFirst() for an EVENT trend query.</param>
        /// <param name="length">The length of the data table, i.e. the number of rows of samples to be searched.</param>
        /// <returns>Query string for CtApiTrend</returns>
        public static string Query(string tag, DateTime datetime, int period, int length)
        {
            string sTime = datetime.ToString("HH:mm:ss");
            string sDate = datetime.ToString("dd.MM.yyyy");
            string sPeriod = period.ToString();
            string sLength = length.ToString();
            string ret = string.Format(@"CTAPITrend(""{0}"",""{1}"",{2},{3},{4},""{5}"")", sTime, sDate, sPeriod, sLength, 0, tag);
            //"CTAPITrend(\"10:15:00 \", \"11/8/1998\", 2, 100, 0,\"CPU\"
            return ret;
        }
    }
}
