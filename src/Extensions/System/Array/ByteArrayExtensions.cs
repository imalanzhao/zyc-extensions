using System;
using System.Collections.Generic;
using System.Text;

namespace Zyc.Extensions
{
    public static class ByteArrayExtensions
    {
        /// <summary>
        /// 将字节数组转成ASCII编码的字符串，可用于字节通讯中字符串的传递解码
        /// </summary>
        /// <param name="bytes">字节数组</param>
        /// <returns>ASCII编码的字符串</returns>
        public static string ToAsciiEncodingString(this Byte[] bytes) {
            if (bytes == null || bytes.Length == 0) return string.Empty;
            return ASCIIEncoding.ASCII.GetString(bytes);
        }

        /// <summary>
        /// 将字节数组的字节值转换成16进制表示，并通过指定的分隔符拼接成字符串，
        /// 例如输入的字节数组为{8,9,10}并且分隔符为','，那么输出为"08，09,0A"。
        /// 可用于字节通讯打印原始字节数据。
        /// </summary>
        /// <param name="bytes">字节数组</param>
        /// <param name="separator">分隔符</param>
        /// <returns>返回拼接后的字符串</returns>
        public static string CombineToHexString(this byte[] bytes, char separator) {
            if (bytes == null || bytes.Length == 0) return string.Empty;

            StringBuilder stringBuilder = new StringBuilder();
            int length = bytes.Length;
            for (int i = 0; i < length; i++) {
                stringBuilder.Append(bytes[i].ToString("X2")).Append(separator);
            }

            stringBuilder.Remove(stringBuilder.Length - 1, 1);//移除最后一个分隔符

            return stringBuilder.ToString();
        }
    }
}
