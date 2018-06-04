﻿using System.Text;

namespace System.Net.CitectClient
{
    public static class FloatExtensions
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
    }
}
