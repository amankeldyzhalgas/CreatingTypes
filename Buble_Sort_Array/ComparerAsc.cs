using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Buble_Sort_Array
{
    /// <summary>
    /// Реализует Icomparer. 
    /// </summary>
    public class ComparerAsc : IComparer
    {
        public static IStrategy Strategy { get; set; }

        public ComparerAsc(IStrategy strategy)
        {
            Strategy = strategy;
        }

        /// <summary>
        /// Метод сравнивает два объекта.
        /// </summary>
        /// <param name="x">Первый объект.</param>
        /// <param name="y">Второй объект.</param>
        /// <returns>
        /// Возвращает '0', если объекты равны, '1', если первый  объект 
        /// больше второго и '-1', если второй объект больше первого.
        /// </returns>
        public int Compare(object x, object y)
        {
            if (ReferenceEquals(x, y))
            {
                return 0;
            }
            else if (x is null)
            {
                return 1;
            }
            else if (y is null)
            {
                return -1;
            }
            var first = Strategy.Algorithm((int[])x);
            var second = Strategy.Algorithm((int[])y);

            if (first == second)
            {
                return 0;
            }
            else if (first > second)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
