using System;
using System.Collections.Generic;
namespace Algo
{
    class KthSmallestElementinaSortedMatrix
    {
        public static int KthSmallest(int[][] matrix, int k)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    list.Add(matrix[i][j]);
                }
            }
            list.Sort();
            return list[k - 1];
        }
        static void Main(string[] args)
        {
            int[][] matrix = { new int[] { 1, 5, 9 }, new int[] { 10, 11, 13 }, new int[] { 12, 13, 15 } };
            System.Console.WriteLine(KthSmallest(matrix, 8));
        }

    }
}