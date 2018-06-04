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

        public TrendEntry(DateTime datetime, string val)
        {
            this.date = datetime.ToString("dd.MM.yyyy");
            this.time = datetime.ToString("HH:mm:ss");
            this.val = val.Trim();
        }

        public DateTime Date
        {
            get
            {
                return DateTime.Parse(date + " " + time);
            }
            //set
            //{
            //    date = value.ToString("dd.MM.yyyy");
            //    time = value.ToString("HH:mm:ss");
            //}
        }

        public float Value
        {
            get
            {
                return val.ToFloat();
            }
        }

        public override string ToString()
        {
            return Date.ToString("dd.MM.yyyy HH:mm:ss") + " " + Value.ToString();
        }
    }
}
