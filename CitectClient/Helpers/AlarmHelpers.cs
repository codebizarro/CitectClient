namespace System.Net.CitectClient
{
    static class AlarmHelpers
    {
        public static string Query(string type, string tag, DateTime dateStart, DateTime dateEnd, double period)
        {
            //`ALMQUERY,Database,TagName,Starttime,StarttimeMs,Endtime,EndtimeMs,Period'
            var ret = string.Empty;
            var start = dateStart.ToSecondsFrom1970().ToString();
            var end = dateEnd.ToSecondsFrom1970().ToString();
            ret = $"ALMQUERY,{type},{tag},{start},0,{end},0,{period}";
            return ret;
        }
    }
}
