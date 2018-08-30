using System;
using System.Collections.Generic;
using System.Text;

namespace Zyc.Extensions
{
    public static class SingleExtensions
    {
        /// <summary>
        /// 获取浮点型数据的绝对值
        /// </summary>
        /// <param name="value"></param>
        /// <returns>返回绝对值</returns>
        public static Single GetAbs(this Single value) {
            return Math.Abs(value);
        }

        /// <summary>
        /// 以小端模式将浮点数值转换成字节数组
        /// </summary>
        /// <param name="value"></param>
        /// <returns>返回字节数组</returns>
        public static Byte[] ToBytes(this Single value) {
            return BitConverter.GetBytes(value);
        }

        /// <summary>
        /// 根据指定的字节序将浮点数值转换成字节数组
        /// </summary>
        /// <param name="value"></param>
        /// <param name="endian"></param>
        /// <returns>返回字节数组</returns>
        public static Byte[] ToBytes(this Single value, Endian endian) {
            return ToBytesHelper.ToBytes(value, ToBytes, endian);
        }
    }
}
