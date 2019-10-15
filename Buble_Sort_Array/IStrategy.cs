using System;
using System.Collections.Generic;
using System.Text;

namespace Buble_Sort_Array
{
    /// <summary>
    /// Интерфейс  для паттерна "Strategy".
    /// </summary>
    public interface IStrategy
    {
        /// <summary>
        /// Этот метод реализует определенный алгоритм.
        /// </summary>
        /// <param name="array">Массив</param>
        /// <returns>Число для сравнении</returns>
        int? Algorithm(int[] array);
    }
}
