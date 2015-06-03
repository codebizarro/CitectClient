using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ctApiWrapper
{
    public class TrendEntry
    {
        string date;
        string time;
        string val;

        public TrendEntry(string date, string time, string val)
        {
            this.date = date.Trim();
            this.time = time.Trim();
            this.val = val.Trim();
        }

        public DateTime Date
        {
            get
            {
                return DateTime.Parse(date + " " + time);
            }
        }

        public float Value
        {
            get
            {
                return float.Parse(val);
            }
        }

        public override string ToString()
        {
            return Date.ToString("dd.MM.yyyy HH:mm:ss") + " " + Value.ToString();
        }
    }
}
