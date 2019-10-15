using System;
using System.Collections.Generic;
using System.Text;

namespace Buble_Sort_Array
{
    public interface IStrategy
    {
        int? Algorithm(int[] array);
    }
}
