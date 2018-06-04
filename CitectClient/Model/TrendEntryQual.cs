using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ctApiWrapper
{
    public class TrendEntryQual
    {
        string datetime;
        string val;
        string quality;

        public TrendEntryQual(string datetime, string val, string quality)
        {
            this.datetime = datetime.Trim();
            this.val = val.Trim();
            this.quality = quality;
        }

        public DateTime Date
        {
            get
            {
                return (int.Parse(datetime)).ToDateTime();
            }
        }

        public float Value
        {
            get
            {
                return val.ToFloat();
            }
        }

        public Quality Qual
        {
            get
            {
                return (Quality)int.Parse(quality);
            }
        }

        public override string ToString()
        {
            return Date.ToString("dd.MM.yyyy HH:mm:ss") + " " + Value.ToString();
        }

    }
}
