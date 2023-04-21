using System;


namespace Algo
{

    class MergeSort
    {

        public static void merge(int[] arr, int l, int mid, int r)
        {

            int x = l, y = mid + 1, z = 0;

            int[] res = new int[r - l + 1];

            while (x <= mid && y <= r)
            {
                if (arr[x] < arr[y])
                {
                    res[z++] = arr[x++];
                }
                else
                {
                    res[z++] = arr[y++];
                }
            }
            while (x <= mid)
            {
                res[z++] = arr[x++];
            }
            while (y <= r)
            {
                res[z++] = arr[y++];
            }
            z = 0;

            for (int i = l; i <= r; i++)
            {
                arr[i] = res[z++];
            }
        }

        public static void mergeSort(int[] arr, int l, int r)
        {
            if (l >= r)
            {
                return;
            }
            int mid = (l + r) / 2;

            mergeSort(arr, l, mid);
            mergeSort(arr, mid + 1, r);
            merge(arr, l, mid, r);

        }

        static void Main(string[] args)
        {

            int[] arr = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            mergeSort(arr, 0, arr.Length - 1);

            foreach (int i in arr)
            {
                System.Console.Write(i + " ");
            }


        }
    }
}