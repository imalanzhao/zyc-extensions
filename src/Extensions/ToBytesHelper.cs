using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Zyc.Extensions
{
    static class ToBytesHelper
    {
        public Byte[] ToBytes<T>(T t, Func<T, Byte[]> toBytesWithLittleEndian, Endian endian) {
            switch (endian) {
                case Endian.BigEndian:
                    return toBytesWithLittleEndian(t).Reverse().ToArray();
                case Endian.LittleEndian:
                    return toBytesWithLittleEndian(t);
                default:
                    throw new ArgumentOutOfRangeException(nameof(endian), "字节序仅能为大小端模式");
            }
        }
    }
}
