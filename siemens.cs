using System;

namespace Algo
{

    class siemens
    {
        public static void seimen2darr(int[,] arr)
        {
            int[] row = new int[arr.GetLength(0)];
            int[] col = new int[arr.GetLength(1)];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == 0)
                    {
                        row[i] = 1;
                        col[j] = 1;
                    }
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (row[i] == 1 || col[j] == 1)
                    {
                        arr[i, j] = 0;
                    }
                }
            }
        }

        public static void printmatrix(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    System.Console.Write(arr[i, j] + " ");
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine("=======================");
        }
        static void Main(string[] args)
        {
            int[,] arr = new int[,] { { 5, 4, 3, 9 }, { 2, 0, 7, 6 }, { 1, 3, 4, 0 }, { 9, 8, 3, 4 } };
            printmatrix(arr);
            seimen2darr(arr);
            printmatrix(arr);
        }
    }
}