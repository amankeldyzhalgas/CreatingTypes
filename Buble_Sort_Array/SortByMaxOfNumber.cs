using System;
using System.Collections.Generic;
using System.Text;

namespace Buble_Sort_Array
{
    /// <summary>
    /// Реализация алгоритма поиска максимального значения.
    /// </summary>
    public class SortByMaxOfNumber: IStrategy
    {
        /// <summary>
        /// Метод возвращает максимальное значение в одномерном массиве.
        /// </summary>
        /// <param name="array">Массив.</param>0
        /// <returns>Число.</returns>
        public int? Algorithm(int[] array)
        {
            if (array is null)
            {
                return null;
            }

            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }
    }
}
