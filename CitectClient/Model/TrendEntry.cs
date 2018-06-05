namespace System.Net.CitectClient
{
    public class TrendEntry: BaseTrendEntry
    {
        private readonly string _date;
        private readonly string _time;

        public TrendEntry(string date, string time, string value): base(value)
        {
            _date = date.Trim();
            _time = time.Trim();
            _value = value.Trim();
            _dateTime = DateTime.Parse($"{date} {time}");
        }

        public TrendEntry(DateTime datetime, string value) : base(value)
        {
            _date = datetime.ToString("dd.MM.yyyy");
            _time = datetime.ToString("HH:mm:ss");
            _value = value.Trim();
        }
    }
}
