using System;
using System.Collections.Generic;
using System.Text;

namespace Zyc.Extensions
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// 将当前字符串转换成ASCII码的字节数组
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static byte[] GetAsciiBytes(this string str) {
            return ASCIIEncoding.ASCII.GetBytes(str);
        }
    }
}
