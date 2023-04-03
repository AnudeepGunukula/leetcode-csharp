using System;

namespace Algo
{


    class LinearSearchUsingRecursion
    {

        public static int helper(int[] arr, int key, int i)
        {
            if (arr[i] == key)
            {
                return i;
            }
            if (i == arr.Length - 1)
            {
                return -1;
            }
            return helper(arr, key, i + 1);

        }
        public static int linearsearch(int[] arr, int key)
        {
            return helper(arr, key, 0);
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine(linearsearch(new int[] { 12, 3, 234, 34, 78, 90 }, 90));

        }

    }

}