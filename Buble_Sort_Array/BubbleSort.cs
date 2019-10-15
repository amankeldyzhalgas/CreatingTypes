using System;

namespace Buble_Sort_Array
{
    public class BubbleSort
    {
        //public static int[,] Generate(int row, int col)
        //{
        //    Random rand = new Random();
        //    int[,] arr = new int[row, col];
        //    for (int i = 0; i < row; i++)
        //    {
        //        for (int j = 0; j < col; j++)
        //        {
        //            arr[i, j] = rand.Next(10);
        //        }
        //    }
        //    return arr;
        //}
        public static int[][] GenerateMatrix(int row, int col)
        {
            int[][] matrix = new int[row][];
            Random rand = new Random();
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[col];
                for (int j = 0; j < matrix[i].Length; j++)
                    matrix[i][j] = rand.Next(10);
            }
            return matrix;
        }

        public static int[] Sort(int[] array)
        {
            int length = array.Length;
            int temp = array[0];
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

        public static int Sum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }
}
