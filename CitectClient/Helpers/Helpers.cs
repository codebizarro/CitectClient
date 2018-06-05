namespace System.Net.CitectClient
{
    static class TrendHelper
    {
        public static string Query(string tag, DateTime datetime, int period, int length)
        {
            var sTime = datetime.ToString("HH:mm:ss");
            var sDate = datetime.ToString("dd.MM.yyyy");
            var sPeriod = period.ToString();
            var sLength = length.ToString();
            var ret = $@"CTAPITrend(""{sTime}"",""{sDate}"",{sPeriod},{sLength},0,""{tag}"")";
            //"CTAPITrend(\"10:15:00 \", \"11/8/1998\", 2, 100, 0,\"CPU\"
            return ret;
        }

        public static string Query(string tag, DateTime datetime, int period, int length, bool interpolate, bool legacy)
        {
            var endTime = datetime.ToSecondsFrom1970().ToString();
            var sPeriod = period.ToString();
            var sLength = length.ToString();
            var ret = string.Empty;
            if (!legacy)
            {
                var iInterpolate = interpolate ? 0 : 1;
                ret = $"TRNQUERY,{endTime},0,{sPeriod}.0,{sLength},{tag},0,{iInterpolate},0,{sPeriod}000";
            }
            else ret = $"TRNQUERY,{endTime},0,{sPeriod}.0,{sLength},{tag},0";
            return ret;
        }
    }
}
