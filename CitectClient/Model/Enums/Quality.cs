using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ctApiWrapper
{
    [Flags]
    public enum Quality
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
