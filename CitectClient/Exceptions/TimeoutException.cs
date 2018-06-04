namespace System.Net.CitectClient
{
    [Serializable]
    public class TimeoutException : Exception
    {
        public TimeoutException()
            : base()
        {
        }

        public TimeoutException(string message)
            : base(message)
        {
        }
    }
}
