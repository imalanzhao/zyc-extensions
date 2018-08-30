using System;
using System.Collections.Generic;
using System.Text;

namespace Zyc.Extensions
{
    public static class Int32Extensions
    {
        /// <summary>
        /// 获取整形数据的绝对值
        /// </summary>
        /// <param name="value"></param>
        /// <returns>返回绝对值</returns>
        public static int GetAbs(this Int32 value) {
            return Math.Abs(value);
        }

        /// <summary>
        /// 以小端模式将整形数据转换成字节数组
        /// </summary>
        /// <param name="value"></param>
        /// <returns>返回字节数组</returns>
        public static Byte[] ToBytes(this Int32 value) {
            return BitConverter.GetBytes(value);
        }

        /// <summary>
        /// 根据指定的字节序模式将整形数值转换成字节数组
        /// </summary>
        /// <param name="value"></param>
        /// <param name="endian"></param>
        /// <returns>返回字节数组</returns>
        public static Byte[] ToBytes(this Int32 value, Endian endian) {
            return ToBytesHelper.ToBytes(value, ToBytes, endian);
        }
    }
}
