using System;
using System.Collections.Generic;
using System.Text;

namespace Buble_Sort_Array
{
    public class SortByMinNumber: IStrategy
    {
        public int? Algorithm(int[] array)
        {
            if (array is null)
            {
                return null;
            }

            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }
    }
}
