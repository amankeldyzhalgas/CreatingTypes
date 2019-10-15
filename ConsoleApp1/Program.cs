using System;
using System.Collections;
using System.Linq;
using Buble_Sort_Array;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //IComparer comparerAscSum = new ComparerAsc(new SortBySumOfNumbers());
            //IComparer comparerDescSum = new ComparerDesc(new SortBySumOfNumbers());
            IComparer comparerAscMax = new ComparerAsc(new SortBySumOfNumbers());
            IComparer comparerDescMax = new ComparerDesc(new SortBySumOfNumbers());
            //int[][] a = Generate(5,5);
            int[][] arr = new int[][] { new int[] { 8, 3, 3, 7 }, new int[] { 2, 6, 3, 7, 5, 1 }, new int[] { 7, 9, 2, 3 } };
            PrintMatrix(arr);
            //var arrAscSum = BubbleSort.Sort(a, comparerAscSum);
            //PrintMatrix(arrAscSum);
            //var arrDescSum = BubbleSort.Sort(a, comparerDescSum);
            //PrintMatrix(arrDescSum);
            var arrAscMax= BubbleSort.Sort(arr, comparerAscMax);
            PrintMatrix(arrAscMax);
            var arrDescMax = BubbleSort.Sort(arr, comparerDescMax);
            PrintMatrix(arrDescMax);
            Console.ReadLine();
        }
        private static void PrintMatrix(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }
        private static int[][] Generate(int row, int col)
        {
            Random rand = new Random();
            int[][] arr = new int[row][];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[col];
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = rand.Next(10);
                }
            }
            return arr;
        }
    }
}
