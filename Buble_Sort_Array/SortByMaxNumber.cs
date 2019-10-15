using System;
using System.Collections.Generic;
using System.Text;

namespace Buble_Sort_Array
{
    public class SortByMaxNumber: IStrategy
    {
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
