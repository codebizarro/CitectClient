using System;
using ctApiWrapper;

namespace ctApiApplication
{
    class Program
    {
        public static void Main(string[] args)
        {
            CitectApi ct = new CitectApi("192.168.22.141", "kernel", "citect", 0);
            while (true)
            {
                ct.Connected = true;
                TimeSpan ts = TimeSpan.FromSeconds(int.Parse(ct.TagRead("Acc_N1_rb")));
                Console.Write("{0:D2}:{1:D2}:{2:D2}", ts.Hours, ts.Minutes, ts.Seconds);
                ct.Connected = false;
                Console.CursorLeft = 0;
                System.Threading.Thread.Sleep(1000);
                //Console.Clear();
            }
            Console.ReadKey(true);
        }
    }
}