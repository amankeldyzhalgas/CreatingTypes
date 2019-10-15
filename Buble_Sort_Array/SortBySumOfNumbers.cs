using System;
using System.Collections.Generic;
using System.Text;

namespace Buble_Sort_Array
{
    public class SortBySumOfNumbers : IStrategy
    {
        public int? Algorithm(int[] array)
        {
            if (array is null)
            {
                return null;
            }
            int sum = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }
    }
}
