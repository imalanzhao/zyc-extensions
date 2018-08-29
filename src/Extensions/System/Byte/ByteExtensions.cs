using System;
using System.Collections.Generic;
using System.Text;

namespace Zyc.Extensions
{
    public static class ByteExtensions
    {
        /// <summary>
        /// 将字节数值转换成十六进制形式的格式化字符串，例如100会被转换成"0x64"
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public static string ToHexString(this Byte b) {
            return $"0x{b.ToString("X2")}";
        }
    }
}
