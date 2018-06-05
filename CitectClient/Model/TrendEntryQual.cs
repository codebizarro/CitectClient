namespace System.Net.CitectClient
{
    public class TrendEntryQual: BaseTrendEntry
    {
        private readonly string _datetime;
        private readonly string _quality;

        public TrendEntryQual(string datetime, string value, string quality) : base(value)
        {
            _datetime = datetime.Trim();
            _value = value.Trim();
            _quality = quality;
            _dateTime = (int.Parse(datetime)).ToDateTime();
        }

        public Quality Quality => (Quality)int.Parse(_quality);
    }
}
