﻿using System;
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
    }
}