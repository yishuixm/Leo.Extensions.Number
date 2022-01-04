using System;

namespace Leo.Extensions
{
    public static class UShortExtension
    {
        public static ushort ExchangeHightAndLow(this ushort value)
        {
            ushort h = (ushort)(value >> 8);
            ushort l = (ushort)(value & 0b0000000011111111);

            return (ushort)((l << 8) + h);
        }
    }
}
