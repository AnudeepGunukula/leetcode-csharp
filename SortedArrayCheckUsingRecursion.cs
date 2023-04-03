using System;

namespace Algo
{


    class SortedArrayCheckUsingRecursion
    {

        public static bool helper(int[] arr, int i)
        {
            if (i == arr.Length - 1)
            {
                return true;
            }

            if (arr[i] > arr[i + 1])
            {
                return false;
            }
            return helper(arr, i + 1);

        }
        public static bool SortArrCheck(int[] arr)
        {
            return helper(arr, 0);
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine(SortArrCheck(new int[] { 1, 2, 13, 4, 5 }));


        }
    }
}