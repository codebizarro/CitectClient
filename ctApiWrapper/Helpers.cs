using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ctApiWrapper
{
    static class CtApiTrend
    {
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

        public static string Query(string tag, DateTime datetime, int period, int length, bool interpolate)
        {
            string endTime = datetime.ToSecondsFrom1970().ToString();
            string sPeriod = period.ToString();
            string sLength = length.ToString();
            int iInterpolate = interpolate ? 0 : 1;
            string ret = string.Format(@"TRNQUERY,{0},0,{1}.0,{2},{3},0,{4},0,{1}000", endTime, sPeriod, sLength, tag, iInterpolate);
            //TRNQUERY,Endtime,EndtimeMs,Period,NumSamples,Tagname,Displaymode,Datamode,InstantTrend,SamplePeriod' 
            //`ALMQUERY,Database,TagName,Starttime,StarttimeMs,Endtime,EndtimeMs,Period'
            return ret;
        }
    }
}
