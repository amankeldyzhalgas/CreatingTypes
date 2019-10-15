using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Buble_Sort_Array
{
    public class Comparer : IComparer
    {
        public static IStrategy Strategy { get; set; }

        public Comparer(IStrategy strategy)
        {
            Strategy = strategy;
        }
        public int Compare(object x, object y)
        {
            var first = Strategy.Algorithm((int[])x);
            var secind = Strategy.Algorithm((int[])y);
        }
    }
}
