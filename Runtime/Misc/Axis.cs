using System;
namespace Lunari.Tsuki.Misc {
    [Flags]
    public enum Axis : byte{
        X = 1 << 0,
        Y = 1 << 1,
        Z = 1 << 2
    }
}