using System;

namespace Algo
{


    class FindPivotInRotatedSortedArray
    {

        public static int findpivot(int[] arr)
        {

            int s = 0;
            int e = arr.Length - 1;

            while (s < e)
            {
                int mid = (s + e) / 2;
                if (arr[mid] >= arr[0])
                {
                    s = mid + 1;
                }
                else
                {
                    e = mid;
                }
            }
            return s;

        }
        public static int binarysearch(int[] arr, int s, int e, int key)
        {
            while (s <= e)
            {
                int mid = (s + e) / 2;
                if (arr[mid] == key)
                {
                    return mid;
                }
                if (arr[mid] > key)
                {
                    e = mid - 1;
                }
                if (arr[mid] < key)
                {
                    s = mid + 1;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 7, 1, 2, 3, 4 };
            int pivot = findpivot(arr);
            int key = 3;
            int s, e;
            if (key >= arr[pivot] && key <= arr[arr.Length - 1])
            {
                s = pivot;
                e = arr.Length - 1;

            }
            else
            {
                s = 0;
                e = pivot - 1;
            }

            System.Console.WriteLine(binarysearch(arr, s, e, key));
        }
    }
}