using System;


namespace Algo
{

    class RotatedSortedArrWithouPivotUsingRecursion
    {

        public static int rotsortarr(int[] arr, int key, int s, int e)
        {
            if (s > e)
            {
                return -1;
            }

            int mid = (s + e) / 2;
            if (arr[mid] == key)
            {
                return mid;
            }
            if (arr[mid] > arr[0])
            {
                if (key >= arr[0] && key <= arr[mid - 1])
                {
                    return rotsortarr(arr, key, s, mid - 1);
                }
                else
                {
                    return rotsortarr(arr, key, mid+1, e);
                }

            }
            else
            {
                if (key >= arr[mid + 1] && key <= arr[e])
                {
                    return rotsortarr(arr, key, mid + 1, e);
                }
                else
                {
                    return rotsortarr(arr, key, s, mid - 1);
                }
            }



        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 8, 9, 10, 1, 2, 3, 4, 5, 6, 7 };
            System.Console.WriteLine(rotsortarr(arr, 6, 0, arr.Length - 1));

        }
    }
}