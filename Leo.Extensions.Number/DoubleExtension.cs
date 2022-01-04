using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leo.Extensions
{
    public static class DoubleExtension
    {
        /// <summary>
        /// 取有数效数字位
        /// </summary>
        /// <param name="value">数字</param>
        /// <param name="precision">精度</param>
        /// <param name="scientificNotation">是否使用科学计数法</param>
        /// <param name="useScientificNotationLength">使用科学计数法的长度</param>
        /// <returns></returns>
        public static string ValidDecimal(this double value, int precision = 2, bool scientificNotation = true, int useScientificNotationLength = 5)
        {
            string ret;
            if (value > 0 || value < 0)
            {
                var valueStr = $"{value}";
                string[] pieces = valueStr.Split('.');
                string iPart = pieces[0], dPart = pieces[1];

                if (scientificNotation)
                    scientificNotation = iPart.Length + dPart.Length > useScientificNotationLength;

                if (!scientificNotation)
                {
                    if (dPart.Length > 10) dPart = dPart.Substring(0, 10);
                    var formatDPart = int.Parse(dPart).ToString(); // 获取无前置零的小数部分
                    var zeroCount = dPart.Length - formatDPart.Length; // 计算前置零个数
                    if (formatDPart.Length < precision) precision = formatDPart.Length;
                    var rDPart = formatDPart.Substring(0, precision); // 获取小数的精度

                    decimal d;
                    if (!decimal.TryParse($"{iPart}.{rDPart.PadLeft(zeroCount + precision, '0')}", out d))
                    {
                        d = 0;
                    }

                    if (d == 0M)
                    {
                        ret = $"0.{"".PadLeft(precision, '0')}";
                    }
                    else
                    {
                        ret = $"{d}";
                    }
                }
                else
                {
                    ret = value.ToScientificNotation(precision);
                }
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
        public static double Round(this double value, int decimals = 0)
        {
            return Math.Round(value, decimals);
        }
    }
}
