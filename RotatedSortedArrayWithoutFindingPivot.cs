using System;

namespace Algo
{

    class RotatedSortedArrayWithoutFindingPivot
    {

        public static int rotsortarrwithoutpivot(int[] arr, int key)
        {
            int s = 0;
            int e = arr.Length - 1;

            while (s <= e)
            {
                int mid = (s + e) / 2;
                if (arr[mid] == key)
                {
                    return mid;
                }
                if (arr[mid] > arr[0])
                {
                    if (key >= arr[0] && key <= arr[mid])
                    {
                        e = mid - 1;
                    }
                    else
                    {
                        s = mid + 1;
                    }
                }
                else
                {
                    if (key >= arr[mid + 1] && key <= arr[e])
                    {
                        s = mid + 1;
                    }
                    else
                    {
                        e = mid - 1;
                    }
                }
            }
            return -1;


        }
        static void Main(string[] args)
        {
            System.Console.WriteLine(rotsortarrwithoutpivot(new int[] { 7, 9, 10, 1, 2, 3, 4, 5, 6 }, 4));

        }
    }
}