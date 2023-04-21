using System;

namespace Algo
{
    class BubbleSortUsingRecursion
    {

        public static void bubblesort(int[] arr, int i, int n)
        {
            if (n == 1)
            {
                return;
            }
            if (i == n - 1)
            {
                bubblesort(arr, 0, n - 1);
            }
            else
            {
                if (arr[i] > arr[i + 1])
                {
                    (arr[i], arr[i + 1]) = (arr[i + 1], arr[i]);
                }
                bubblesort(arr, i + 1, n);
            }

        }
        static void Main(string[] args)
        {
            int[] arr = { 5, 4, 3, 2, 1 };
            bubblesort(arr, 0, arr.Length);

            foreach (var i in arr)
            {
                System.Console.Write(i + " ");
            }
        }
    }
}