using Buble_Sort_Array;
using NUnit.Framework;
using System.Collections;

namespace Bubble_Sort_Array_Tests
{
    [TestFixture]
    public class UnitTest
    {
        //private int[][] _arr = new int[][] { new int[] { 8, 3, 3, 7, 8, 4, 3 }, new int[] { 3, 7, 9, 1, 3 }, null, new int[] { 2, 6, 3, 7 } };
        //private int[][] _exp = new int[][] { new int[] { 8, 3, 3, 7, 8, 4, 3 }, new int[] { 3, 7, 9, 1, 3 }, null, new int[] { 2, 6, 3, 7 } };
        //[Test, TestCaseSource("_arr")]

        [TestCase()]
        public void UTestSortAscBySumOfNumbers()
        {
            int[][] arr = new int[][] { new int[] { 8, 3, 3, 7 }, new int[] { 2, 6, 3, 7, 5, 1 }, new int[] { 7, 9, 2, 3 } };
            int[][] excepted = new int[][] { new int[] { 8, 3, 3, 7 }, new int[] { 7, 9, 2, 3 }, new int[] { 2, 6, 3, 7, 5, 1 } };
            IComparer comparer = new ComparerAsc(new SortBySumOfNumbers());
            BubbleSort.Sort(arr, comparer);
            Assert.AreEqual(arr, excepted);
        }

        [TestCase()]
        public void UTestSortDescBySumOfNumbers()
        {
            int[][] arr = new int[][] { new int[] { 8, 3, 3, 7 }, new int[] { 2, 6, 3, 7, 5, 1 }, new int[] { 7, 9, 2, 3 } };
            int[][] excepted = new int[][] { new int[] { 2, 6, 3, 7, 5, 1 }, new int[] { 8, 3, 3, 7 }, new int[] { 7, 9, 2, 3 } };
            IComparer comparer = new ComparerDesc(new SortBySumOfNumbers());
            BubbleSort.Sort(arr, comparer);
            Assert.AreEqual(arr, excepted);
        }
        [TestCase()]
        public void UTestSortAscByMaxNumber()
        {
            int[][] arr = new int[][] { new int[] { 8, 3, 3, 7 }, new int[] { 2, 6, 3, 7, 5, 1 }, new int[] { 7, 9, 2, 3 } };
            int[][] excepted = new int[][] { new int[] { 2, 6, 3, 7, 5, 1 }, new int[] { 8, 3, 3, 7 }, new int[] { 7, 9, 2, 3 } };
            IComparer comparer = new ComparerAsc(new SortByMaxOfNumber());
            BubbleSort.Sort(arr, comparer);
            Assert.AreEqual(arr, excepted);
        }

        [TestCase()]
        public void UTestSortDescByMaxNumber()
        {
            int[][] arr = new int[][] { new int[] { 8, 3, 3, 7 }, new int[] { 2, 6, 3, 7, 5, 1 }, new int[] { 7, 9, 2, 3 } };
            int[][] excepted = new int[][] {new int[] { 7, 9, 2, 3 }, new int[] { 8, 3, 3, 7 }, new int[] { 2, 6, 3, 7, 5, 1 } };
            IComparer comparer = new ComparerDesc(new SortByMaxOfNumber());
            BubbleSort.Sort(arr, comparer);
            Assert.AreEqual(arr, excepted);
        }
        [TestCase()]
        public void UTestSortAscByMinNumber()
        {
            int[][] arr = new int[][] { new int[] { 8, 3, 3, 7 }, new int[] { 2, 6, 3, 7, 5, 1 }, new int[] { 7, 9, 2, 3 } };
            int[][] excepted = new int[][] { new int[] { 2, 6, 3, 7, 5, 1 }, new int[] { 7, 9, 2, 3 }, new int[] { 8, 3, 3, 7 } };
            IComparer comparer = new ComparerAsc(new SortByMinOfNumber());
            BubbleSort.Sort(arr, comparer);
            Assert.AreEqual(arr, excepted);
        }

        [TestCase()]
        public void UTestSortDescByMinNumber()
        {
            int[][] arr = new int[][] { new int[] { 8, 3, 3, 7 }, new int[] { 2, 6, 3, 7, 5, 1 }, new int[] { 7, 9, 2, 3 } };
            int[][] excepted = new int[][] { new int[] { 8, 3, 3, 7 }, new int[] { 7, 9, 2, 3 }, new int[] { 2, 6, 3, 7, 5, 1 } };
            IComparer comparer = new ComparerDesc(new SortByMinOfNumber());
            BubbleSort.Sort(arr, comparer);
            Assert.AreEqual(arr, excepted);
        }
    }
}