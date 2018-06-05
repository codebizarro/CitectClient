using System.Text;
using System.Threading;

namespace System.Net.CitectClient
{
    public static class FloatExtensions
    {
        public static float ToFloat(this string input)
        {
            var b = new StringBuilder(input);
            return float.Parse(b.Replace(".", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator).ToString());
        }

        public static double ToDouble(this string input)
        {
            var b = new StringBuilder(input);
            return double.Parse(b.Replace(".", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                        .Replace(",", Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator).ToString());
        }
    }
}
