using System.Collections.Generic;

namespace System.Net.CitectClient
{
    public interface ICitectClient: IDisposable
    {
        bool Connected { get; }
        void Close();
        int FindClose(int Handle);
        int FindFirst(string TableName, string Filter, out uint ObjectHandle);
        int FindNext(int Handle, out uint ObjectHandle);
        int FindPrev(int Handle, out uint ObjectHandle);
        int FindScroll(int Handle, uint Mode, int Offset, out uint ObjectHandle);
        DateTime GetDateTime();
        string GetProperty(uint handle, string Name, int ReturnType);
        void Open(int timeout = 5000);
        string TagRead(string Tag);
        void TagWrite(string Tag, string Value);
        IEnumerable<TrendEntry> TrendRead(string tag, DateTime dateRight, DateTime dateLeft);
        IEnumerable<TrendEntryQual> TrendRead(string tag, DateTime dateRight, DateTime dateLeft, bool interpolate, bool legacy = true);
        IEnumerable<TrendEntry> TrendRead(string tag, DateTime dateRight, int length);
        IEnumerable<TrendEntryQual> TrendRead(string tag, DateTime dateRight, int length, bool interpolate, bool legacy = true);
    }
}