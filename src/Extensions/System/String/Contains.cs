using System;
using System.Collections.Generic;
using System.Text;

namespace Zyc.Extensions
{
    public static partial class StringExtensions {
        /// <summary>
        /// 判断当前字符串是否包含指定的字符串
        /// </summary>
        /// <param name="str"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool Contains(this string str, string value) {
            return str.IndexOf(value) != -1;
        }

        /// <summary>
        /// 判断当前字符串是否包含指定的字符串
        /// </summary>
        /// <param name="str"></param>
        /// <param name="value"></param>
        /// <param name="stringComparison"></param>
        /// <returns></returns>
        public static bool Contains(this string str, string value, StringComparison stringComparison) {
            return str.IndexOf(value, stringComparison) != -1;
        }
    }
}
