using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leo.Extensions
{
    public static class ScientificNotationExtension
    {
        /// <summary>
        /// 转成科学计数法
        /// </summary>
        /// <param name="i"></param>
        /// <param name="precision"></param>
        /// <returns></returns>
        public static string ToScientificNotation(this int i, int precision = 2)
        {
            return i.ToString($"e{precision}");
        }

        /// <summary>
        /// 转成科学计数法
        /// </summary>
        /// <param name="i"></param>
        /// <param name="precision"></param>
        /// <returns></returns>
        public static string ToScientificNotation(this uint i, int precision = 2)
        {
            return i.ToString($"e{precision}");
        }

        /// <summary>
        /// 转成科学计数法
        /// </summary>
        /// <param name="l"></param>
        /// <param name="precision"></param>
        /// <returns></returns>
        public static string ToScientificNotation(this long l, int precision = 2)
        {
            return l.ToString($"e{precision}");
        }

        /// <summary>
        /// 转成科学计数法
        /// </summary>
        /// <param name="l"></param>
        /// <param name="precision"></param>
        /// <returns></returns>
        public static string ToScientificNotation(this ulong l, int precision = 2)
        {
            return l.ToString($"e{precision}");
        }

        /// <summary>
        /// 转成科学计数法
        /// </summary>
        /// <param name="d"></param>
        /// <param name="precision"></param>
        /// <returns></returns>
        public static string ToScientificNotation(this decimal d, int precision = 2)
        {
            return d.ToString($"e{precision}");
        }

        /// <summary>
        /// 转成科学计数法
        /// </summary>
        /// <param name="f"></param>
        /// <param name="precision"></param>
        /// <returns></returns>
        public static string ToScientificNotation(this float f, int precision = 2)
        {
            return f.ToString($"e{precision}");
        }

        /// <summary>
        /// 转成科学计数法
        /// </summary>
        /// <param name="d"></param>
        /// <param name="precision"></param>
        /// <returns></returns>
        public static string ToScientificNotation(this double d, int precision = 2)
        {
            return d.ToString($"e{precision}");
        }
    }
}
