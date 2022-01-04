using System;

namespace Leo.Extensions
{
    public static class DecimalExtension
    {
        /// <summary>
        /// 取有数效数字位
        /// </summary>
        /// <param name="value">数字</param>
        /// <param name="precision">精度</param>
        /// <param name="scientificNotation">是否使用科学计数法</param>
        /// <param name="useScientificNotationLength">使用科学计数法的长度</param>
        /// <returns></returns>
        public static string ValidDecimal(this decimal value, int precision = 2, bool scientificNotation = true, int useScientificNotationLength = 5)
        {
            string ret;
            if (value > 0 || value < 0)
            {
                var valueStr = $"{value}";
                string[] pieces = valueStr.Split('.');
                if (pieces.Length == 1) pieces = new string[] { pieces[0], "0" };
                string iPart = pieces[0], dPart = pieces[1];

                ret = NumberTools.ValidDecimal(iPart, dPart, precision, scientificNotation, useScientificNotationLength);
            }
            else
            {
                ret = $"0.{"".PadLeft(precision, '0')}";
            }


            return ret;
        }

        /// <summary>
        /// 四舍五入
        /// </summary>
        /// <param name="value"></param>
        /// <param name="decimals"></param>
        /// <returns></returns>
        public static decimal Round(this decimal value, int decimals = 0)
        {
            return Math.Round(value, decimals);
        }
    }
}
