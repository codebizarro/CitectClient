namespace System.Net.CitectClient
{
    public class BaseTrendEntry: BaseEntry
    {
        protected string _value;

        public BaseTrendEntry(string value)
        {
            _value = value;
        }

        public float Value => _value.ToFloat();

        public override string ToString() => $"{Date.ToString("dd.MM.yyyy HH:mm:ss")} {Value.ToString()}";
    }
}
