namespace System.Net.CitectClient
{
    public class AlarmEntry : BaseEntry
    {
        private readonly int _mSeconds;
        private readonly string _comment;
        private readonly uint _value;
        public AlarmEntry(string dateTime, string mSeconds, string comment, string value)
        {
            _dateTime = (int.Parse(dateTime)).ToDateTime();
            _mSeconds = int.Parse(mSeconds);
            _comment = comment;
            _value = uint.Parse(value);
        }       
    }
}
