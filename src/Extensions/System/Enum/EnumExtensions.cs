using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel;

namespace Zyc.Extensions
{
    public static class EnumExtensions
    {
        /// <summary>
        /// 获取所有枚举值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<T> GetAll<T>() {
            if (!typeof(T).IsEnum) {
                throw new InvalidOperationException($"不能为不是Enum类型的类执行{nameof(GetAll)}方法");
            }

            var array = Enum.GetValues(typeof(T));
            int length = array.Length;
            T[] ts = new T[length];
            for (int i = 0; i < length; i++) {
                ts[i] = (T)array.GetValue(i);
            }

            return ts;
        }

        /// <summary>
        /// 获取枚举值上的<see cref="DescriptionAttribute"/>的<see cref="DescriptionAttribute.Description"/>值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IReadOnlyDictionary<T, string> GetDescriptions<T>() {
            if (!typeof(T).IsEnum) {
                throw new InvalidOperationException($"不能为不是Enum类型的类执行{nameof(GetDescriptions)}方法");
            }

            var values = typeof(T).GetEnumValues();
            int length = values.Length;
            Dictionary<T, string> dic = new Dictionary<T, string>(length);

            for (int i = 0; i < length; i++) {
                object value = values.GetValue(i);
                string description = GetDescription((Enum)value);
                if (string.IsNullOrEmpty(description)) continue;

                dic[(T)value] = description;
            }

            return dic;
        }

        private static string GetDescription(Enum e) {
            string description = (e.GetType()
                .GetMember(e.ToString()).FirstOrDefault()
                ?.GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault()
                as DescriptionAttribute)
                .Description;

            return description;
        }
    }
}
