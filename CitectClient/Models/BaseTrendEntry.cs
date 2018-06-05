namespace System.Net.CitectClient
{
    public class BaseTrendEntry
    {
        protected string _value;

        protected DateTime _dateTime;

        public BaseTrendEntry(string value)
        {
            _value = value;
        }

        public DateTime Date => _dateTime;

        public float Value => _value.ToFloat();

        public override string ToString() => $"{Date.ToString("dd.MM.yyyy HH:mm:ss")} {Value.ToString()}";
    }
}
