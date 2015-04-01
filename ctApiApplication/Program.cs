using System;
using ctApiWrapper;
using System.Globalization;

namespace ctApiApplication
{
    class Program
    {
        public static void Main(string[] args)
        {
            CultureInfo customCulture = (CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            CitectApi ct = new CitectApi("192.168.22.141", "kernel", "citect", 0);
            while (true)
            {
                ct.Connected = true;
                string s = ct.TagRead("SEC15_REG_W1_M151_PV");
                float f = float.Parse(s);
                Console.Write("{0:F2}", f);
                ct.Connected = false;
                Console.CursorLeft = 0;
                System.Threading.Thread.Sleep(100);
                //Console.Clear();
            }
            Console.ReadKey(true);
        }
    }
}