using System;
using System.Collections.Generic;
using System.Text;

namespace Leo.Extensions
{
    public static class NumberTools
    {
        public static string ValidDecimal(string iPart, string dPart, int precision = 2, bool scientificNotation = true, int useScientificNotationLength = 5)
        {
            string ret;

            if (dPart.Length > 9) dPart = dPart.Substring(0, 9);

            if (scientificNotation)
                scientificNotation = iPart.Length + dPart.Length > useScientificNotationLength;

            if (!scientificNotation)
            {
                int dPrecision = precision - iPart.Length;

                if (dPrecision > 0)
                {
                    ret = $"{iPart}.{dPart.PadLeft(dPrecision, '0').Substring(0, dPrecision)}";
                }
                else
                {
                    ret = iPart;
                }
            }
            else
            {
                ret = $"{iPart}.{dPart}".ToDouble().ToScientificNotation(precision);
            }

            return ret;
        }
    }
}
