namespace System.Net.CitectClient
{
    public static class DateTimeExtensions
    {
        public static double ConvertToUnixTimestamp(this DateTime date)
        {
            var origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            var diff = date.ToUniversalTime() - origin;
            return Math.Floor(diff.TotalSeconds);
        }

        public static int ToSecondsFrom1970(this DateTime date)
        {
            var origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            var diff = date.ToUniversalTime() - origin;
            return (int)(diff.TotalSeconds);
        }

        public static DateTime ToDateTime(this int seconds)
        {
            var origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return origin.AddSeconds(seconds).ToLocalTime();
        }
    }
}
