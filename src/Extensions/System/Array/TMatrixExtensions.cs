using System;
using System.Collections.Generic;
using System.Text;

namespace Zyc.Extensions.System.Array
{
    public static class TMatrixExtensions
    {
        /// <summary>
        /// 获取二维数组的行数
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="matrix"></param>
        /// <returns>返回二维数组的行数</returns>
        public static int GetRows<T>(this T[,] matrix) {
            return matrix.GetLength(0);
        }

        /// <summary>
        /// 获取二维数组的列数
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="matrix"></param>
        /// <returns>返回二维数组的列数</returns>
        public static int GetColumns<T>(this T[,] matrix) {
            return matrix.GetLength(1);
        }

        /// <summary>
        /// 将二维数组逐行地转换成一维数组
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static T[] ToOneDArrayRowByRow<T>(this T[,] matrix) {

            if (matrix == null) throw new ArgumentNullException(nameof(matrix));

            int rows = matrix.GetRows();
            int columns = matrix.GetColumns();
            T[] array = new T[rows * columns];
            int index = 0;
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < columns; j++) {
                    array[index++] = matrix[i, j];
                }
            }

            return array;
        }

        /// <summary>
        /// 将二维数组逐列地转换成一维数组
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static T[] ToOneDArrayColumnByColumn<T>(this T[,] matrix) {

            if (matrix == null) throw new ArgumentNullException(nameof(matrix));

            int rows = matrix.GetRows();
            int columns = matrix.GetColumns();
            T[] array = new T[rows * columns];
            int index = 0;
            for (int i = 0; i < columns; i++) {
                for (int j = 0; j < rows; j++) {
                    array[index++] = matrix[j, i];
                }
            }

            return array;
        }

        /// <summary>
        /// 将当前二维数组转换成指定类型的二维数组
        /// </summary>
        /// <typeparam name="Tin"></typeparam>
        /// <typeparam name="Tout"></typeparam>
        /// <param name="matrix"></param>
        /// <param name="convertTo"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public static Tout[,] ConvertTo<Tin, Tout>(this Tin[,] matrix, Func<Tin, Tout> convertTo) {
            if (matrix == null) throw new ArgumentNullException(nameof(matrix));
            if (convertTo == null) throw new ArgumentNullException(nameof(convertTo));

            int rows = matrix.GetRows();
            int columns = matrix.GetColumns();
            Tout[,] newMatrix = new Tout[rows, columns];

            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < columns; j++) {
                    newMatrix[i, j] = convertTo(matrix[i, j]);
                }
            }

            return newMatrix;
        }
    }
}
