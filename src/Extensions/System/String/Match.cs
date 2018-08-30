using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Zyc.Extensions {
    public static partial class StringExtensions {
        /// <summary>
        /// 判断当前字符串是否匹配正则表达式
        /// </summary>
        /// <param name="str"></param>
        /// <param name="regexString"></param>
        /// <returns></returns>
        public static bool IsMatch(this string str, string regexString) {
            return Regex.IsMatch(str, regexString);
        }

        /// <summary>
        /// 在当前字符串中搜索指定的正则表达式的第一个匹配项
        /// </summary>
        /// <param name="str"></param>
        /// <param name="regexString"></param>
        /// <returns>返回<see cref="System.Text.RegularExpressions.Match"/></returns>
        public static Match Match(this string str, string regexString) {
            return Regex.Match(str, regexString);
        }

        /// <summary>
        /// 在当前字符串中搜索指定的正则表达式的所有匹配项
        /// </summary>
        /// <param name="str"></param>
        /// <param name="regexString"></param>
        /// <returns></returns>
        public static MatchCollection Matches(this string str, string regexString) {
            return Regex.Matches(str, regexString);
        }
    }
}
