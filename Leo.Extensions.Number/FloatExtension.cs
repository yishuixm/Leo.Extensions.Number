using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leo.Extensions
{
    public static class FloatExtension
    {
        /// <summary>
        /// 取有数效数字位
        /// </summary>
        /// <param name="value">数字</param>
        /// <param name="precision">精度</param>
        /// <param name="scientificNotation">是否使用科学计数法</param>
        /// <param name="useScientificNotationLength">使用科学计数法的长度</param>
        /// <returns></returns>
        public static string ValidDecimal(this float value, int precision = 2, bool scientificNotation = true, int useScientificNotationLength = 5)
        {
            string ret;
            if (value > 0 || value < 0)
            {
                var valueStr = $"{value}";
                string[] pieces = valueStr.Split('.');
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
        public static double Round(this float value, int decimals = 0)
        {
            return Math.Round(value, decimals);
        }
    }
}
