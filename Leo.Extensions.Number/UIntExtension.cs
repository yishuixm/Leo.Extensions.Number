using System;

namespace Leo.Extensions
{
    public static class UIntExtension
    {
        public static uint ExchangeHightAndLow(this uint value)
        {
            uint h = value >> 16;
            uint l = value & 0b00000000000000001111111111111111;

            return (l << 16) + h;
        }
    }
}
