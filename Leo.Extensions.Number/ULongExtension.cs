using System;

namespace Leo.Extensions
{
    public static class ULongExtension
    {
        public static ulong ExchangeHightAndLow(this ulong value)
        {
            ulong h = value >> 32;
            ulong l = value & 0b0000000000000000000000000000000011111111111111111111111111111111;

            return (l << 32) + h;
        }
    }
}
