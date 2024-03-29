﻿namespace System.Net.CitectClient
{
    public static class OpenOptionsEnum
    {
        public const int CT_OPEN_CRYPT = 0x00000001; /* use encryption */
        public const int CT_OPEN_RECONNECT = 0x00000002; /* reconnect on failure */
        public const int CT_OPEN_READ_ONLY = 0x00000004; /* read only mode */
        public const int CT_OPEN_BATCH = 0x00000008; /* batch mode */
    }
}
