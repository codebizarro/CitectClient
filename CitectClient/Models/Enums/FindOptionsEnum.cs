namespace System.Net.CitectClient
{
    public static class FindOptionsEnum
    {
        public const uint CT_FIND_SCROLL_NEXT = 0x00000001; /* scroll to next record	*/
        public const uint CT_FIND_SCROLL_PREV = 0x00000002; /* scroll to prev record	*/
        public const uint CT_FIND_SCROLL_FIRST = 0x00000003; /* scroll to first record */
        public const uint CT_FIND_SCROLL_LAST = 0x00000004; /* scroll to last record	*/
        public const uint CT_FIND_SCROLL_ABSOLUTE = 0x00000005; /* scroll to absolute record	*/
        public const uint CT_FIND_SCROLL_RELATIVE = 0x00000006; /* scroll to relative record	*/
    }
}
