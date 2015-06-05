using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ctApiWrapper
{
    public static class Extensions
    {
        public static float ToFloat(this string input)
        {
            StringBuilder b = new StringBuilder(input);
            return float.Parse(b.Replace(".", System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator).ToString());
        }

        public static double ToDouble(this string input)
        {
            StringBuilder b = new StringBuilder(input);
            return double.Parse(b.Replace(".", System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator).ToString());
        }

        public static double ConvertToUnixTimestamp(this DateTime date)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            TimeSpan diff = date.ToUniversalTime() - origin;
            return Math.Floor(diff.TotalSeconds);
        }

        public static int ToSecondsFrom1970(this DateTime date)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            TimeSpan diff = date.ToUniversalTime() - origin;
            return (int)(diff.TotalSeconds);
        }

        public static DateTime ToDateTime(this int seconds)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return origin.AddSeconds(seconds).ToLocalTime();
        }
    }
}
