using System;
using System.Collections.Generic;
using System.Text;

namespace Zyc.Extensions
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 判断当前字符串是否为数字
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsNumeric(this string str) {
            return str.IsMatch("[^0-9]");
        }
    }
}
