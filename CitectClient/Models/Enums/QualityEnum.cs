namespace System.Net.CitectClient
{
    [Flags]
    public enum QualityEnum
    {
        None = 0x1,
        Interpolated = 0x2,
        SingleRaw = 0x4,
        MultipleRaw = 0x8,
        Bad = 0x10,
        Good = 0x20,
        LastBad = 0x100,
        LastGood = 0x200,
        NotAvailable = 0x400,
        Gated = 0x800,
        Changed = 0x1000
    }
}
