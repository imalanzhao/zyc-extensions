using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Zyc.Extensions
{
    public static class DoubleExtensions
    {
        /// <summary>
        /// 获取双精度值的绝对值
        /// </summary>
        /// <param name="val"></param>
        /// <returns>返回绝对值</returns>
        public static double GetAbs(this double val) {
            return Math.Abs(val);
        }

        /// <summary>
        /// 根据指定的字节序模式将双精度数值转换成字节数组，常用于字节通讯中
        /// </summary>
        /// <param name="val"></param>
        /// <returns>返回字节数组</returns>
        public static Byte[] ToBytes(this double val, Endian endian) {
            //switch (endian) {
            //    case Endian.BigEndian:
            //        return BitConverter.GetBytes(val).Reverse().ToArray();
            //    case Endian.LittleEndian:
            //        return BitConverter.GetBytes(val);
            //    default:
            //        throw new ArgumentOutOfRangeException(nameof(endian), "字节序仅能为大小端模式");
            //}
            return ToBytesHelper.ToBytes(val, ToBytes, endian);
        }

        /// <summary>
        /// 以小端模式将双精度值转换成字节数组
        /// </summary>
        /// <param name="val"></param>
        /// <returns>返回字节数组</returns>
        public static Byte[] ToBytes(this double val) {
            return BitConverter.GetBytes(val);
        }
    }
}
