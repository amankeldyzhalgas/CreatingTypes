using System;
using System.Linq;
using Buble_Sort_Array;

namespace ConsoleApp1
{
    public enum SumProterty { ByDescendingSum, ByAscendingSum }
    public enum ElementProterty { ByDescendingElements, ByAscendingElements }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //var arr = Generate(5, 3);
            //var arr2 = Generate(4, 4);
            //Print(arr);
            //arr = sortBySum(arr, SumProterty.ByAscendingSum);
            //Print(arr);
            //arr2 = sortBySum(arr, SumProterty.ByDescendingSum);
            //Print(arr2);
            //arr = sortByElement(arr, ElementProterty.ByAscendingElements);
            //Print(arr);
            //arr2 = sortByElement(arr, ElementProterty.ByDescendingElements);
            //Print(arr2);
            */
            Console.WriteLine("ввести число строк m");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ввести число столбцов n");
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] mas = new int[m][];
            Random rand = new Random();
            int[,] a = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                mas[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    mas[i][j] = rand.Next(0, 10);
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mas[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("SORT");
            var res = mas.OrderBy(o => o.Max()).ToArray();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(res[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();


            //var matrix = Buble_Sort_Array.Program.GenerateMatrix(5,5); 
            //PrintMatrix(matrix);

            Console.ReadLine();
        }
        //private static void Print(int[,] arr)
        //{
        //    for (int i = 0; i < arr.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < arr.GetLength(1); j++)
        //        {
        //            Console.Write(arr[i, j] + " ");
        //        }
        //        Console.WriteLine("");
        //    }
        //    Console.WriteLine("");
        //}
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

        private static int[,] Generate(int row, int col)
        {
            Random rand = new Random();
            int[,] arr = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i, j] = rand.Next(10);
                }
            }
            return arr;
        }

        private static void Swap(ref int firstRow, ref int secondRow)
        {
            var temp = firstRow;
            firstRow = secondRow;
            secondRow = temp;
        }
        private static int[,] sortBySum(int[,] arr, SumProterty proterty)
        {
            for (int rowCount = 0; rowCount < arr.GetLength(0); rowCount++)
            {
                int minSum = int.MinValue;
                int maxSum = int.MaxValue;
                for (int row = 0; row < arr.GetLength(0); row++)
                {
                    int rowSum = 0;
                    for (int col = 0; col < arr.GetLength(1); col++)
                        rowSum += arr[row, col];
                    switch (proterty)
                    {
                        case SumProterty.ByDescendingSum:
                            if (rowSum >= maxSum)
                                for (int col = 0; col < arr.GetLength(1); col++)
                                    Swap(ref arr[row, col], ref arr[row - 1, col]);
                            maxSum = rowSum;
                            break;
                        case SumProterty.ByAscendingSum:
                            if (rowSum <= minSum)
                                for (int col = 0; col < arr.GetLength(1); col++)
                                    Swap(ref arr[row, col], ref arr[row - 1, col]);
                            minSum = rowSum;
                            break;
                        default:
                            break;
                    }
                }
            }
            return arr;
        }

        private static int[,] sortByElement(int[,] arr, ElementProterty proterty)
        {
            for (int rowCount = 0; rowCount < arr.GetLength(0); rowCount++)
            {
                for (int row = 0; row < arr.GetLength(0); row++)
                {
                    for (int col = 0; col < arr.GetLength(1)-1; col++)
                    {
                        if (arr[row, col] > arr[row, col + 1])
                            Swap(ref arr[row, col], ref arr[row, col + 1]);
                        switch (proterty)
                        {
                            case ElementProterty.ByDescendingElements:
                                if (arr[row, col] > arr[row, col + 1])
                                    Swap(ref arr[row, col], ref arr[row, col + 1]);
                                break;
                            case ElementProterty.ByAscendingElements:
                                if (arr[row, col] < arr[row, col + 1])
                                    Swap(ref arr[row, col], ref arr[row, col + 1]);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            return arr;
        }
    }
}
