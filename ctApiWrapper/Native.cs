using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ctApiWrapper
{
    static class Native
    {
        [DllImport("ctapi.dll", EntryPoint = "ctOpen", SetLastError = true, CharSet = CharSet.Ansi, ThrowOnUnmappableChar = true)]
        public static extern IntPtr ctOpen(string sComputer, string sUser, string sPassword, uint nMode);

        [DllImport("ctapi.dll", EntryPoint = "ctClose", SetLastError = true, CharSet = CharSet.Ansi, ThrowOnUnmappableChar = true)]
        public static extern IntPtr ctClose(IntPtr hCtapi);

        [DllImport("ctapi.dll", EntryPoint = "ctTagRead", SetLastError = true, CharSet = CharSet.Ansi, ThrowOnUnmappableChar = true)]
        public static extern IntPtr ctTagRead(IntPtr hCtapi, string sTag, [MarshalAs(UnmanagedType.LPStr)] StringBuilder sValue, uint dwLength);

        [DllImport("ctapi.dll", EntryPoint = "ctTagWrite", SetLastError = true, CharSet = CharSet.Ansi, ThrowOnUnmappableChar = true)]
        public static extern IntPtr ctTagWrite(IntPtr hCtapi, string sTag, string sValue);

        [DllImport("ctapi.dll", EntryPoint = "ctCicode", SetLastError = true, CharSet = CharSet.Ansi, ThrowOnUnmappableChar = true)]
        public static extern IntPtr ctCicode(IntPtr hCTAPI, string sCmd, uint hWin, uint nMode, [MarshalAs(UnmanagedType.LPStr)] StringBuilder sResult, uint dwLength, uint pctOverlapped);

        [DllImport("ctapi.dll", EntryPoint = "ctFindFirst", SetLastError = true, CharSet = CharSet.Ansi, ThrowOnUnmappableChar = true)]
        public static extern IntPtr ctFindFirst(IntPtr hCtapi, [MarshalAs(UnmanagedType.LPStr)]string szTableName, [MarshalAs(UnmanagedType.LPStr)]string szFilter, out uint pObjHnd, uint dwFlags = 0);

        [DllImport("ctapi.dll", EntryPoint = "ctFindNext", SetLastError = true, CharSet = CharSet.Ansi, ThrowOnUnmappableChar = true)]
        public static extern IntPtr ctFindNext(IntPtr handle, out uint pObjHnd);

        [DllImport("ctapi.dll", EntryPoint = "ctFindPrev", SetLastError = true, CharSet = CharSet.Ansi, ThrowOnUnmappableChar = true)]
        public static extern IntPtr ctFindPrev(IntPtr handle, out uint pObjHnd);

        [DllImport("ctapi.dll", EntryPoint = "ctFindScroll", SetLastError = true, CharSet = CharSet.Ansi, ThrowOnUnmappableChar = true)]
        public static extern IntPtr ctFindScroll(IntPtr handle, uint dwMode, int dwOffset, out uint pObjHnd);

        [DllImport("ctapi.dll", EntryPoint = "ctFindClose", SetLastError = true, CharSet = CharSet.Ansi, ThrowOnUnmappableChar = true)]
        public static extern IntPtr ctFindClose(IntPtr handle);

        [DllImport("ctapi.dll", EntryPoint = "ctGetProperty", SetLastError = true, CharSet = CharSet.Ansi, ThrowOnUnmappableChar = true)]
        public static extern IntPtr ctGetProperty(IntPtr handle, string szName, [MarshalAs(UnmanagedType.LPStr)] StringBuilder pData, uint dwBufferLength, out uint dwResultLength, int dwType);

        [System.Runtime.InteropServices.DllImport("Kernel32")]
        public extern static Boolean CloseHandle(IntPtr handle);
    }
}
