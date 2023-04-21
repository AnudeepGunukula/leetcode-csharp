using System;

namespace Algo
{

    class RotateImage
    {
        public static void Rotate(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
                }
            }


            foreach (var arr in matrix)
            {
                Array.Reverse(arr);
            }
        }

        static void Main(string[] args)
        {
            int[][] arr = { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };
            Rotate(arr);
            foreach (var x in arr)
            {
                System.Console.WriteLine(string.Join(',', x));
            }
        }
    }
}