using System;

namespace Algo
{


    class QuickSort
    {

        public static int partition(int[] arr, int l, int r)
        {
            int i = l - 1;
            int pivot = arr[r];

            for (int j = l; j < r; j++)
            {
                if (pivot > arr[j])
                {
                    i++;
                    (arr[i], arr[j]) = (arr[j], arr[i]);

                }
            }
            (arr[i + 1], arr[r]) = (arr[r], arr[i + 1]);

            return (i + 1);


        }

        public static void quickSort(int[] arr, int l, int r)
        {
            if (l >= r)
            {
                return;
            }
            int mid = partition(arr, l, r);
            quickSort(arr, l, mid - 1);
            quickSort(arr, mid + 1, r);


        }
        static void Main(string[] args)
        {
            int[] arr = { 9, 8, 7, 3, 2, 1, 0 };

            quickSort(arr, 0, arr.Length - 1);

            foreach (var i in arr)
            {
                System.Console.Write(i + " ");
            }


        }
    }
}