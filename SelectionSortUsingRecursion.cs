using System;
namespace Algo
{


    class SelectionSortUsingRecursion
    {

        public static void selectionsort(int[] arr, int i, int j, int min, int n)
        {
            if (i == n)
            {
                return;
            }
            if (j == n)
            {
                if (arr[i] > arr[min])
                {
                    (arr[i], arr[min]) = (arr[min], arr[i]);
                }
                selectionsort(arr, i + 1, i + 2, i + 1, n);

            }
            else
            {
                if (arr[min] > arr[j])
                {
                    min = j;
                }
                selectionsort(arr, i, j + 1, min, n);
            }




        }

        static void Main(string[] args)
        { 

            int[] arr = { 100, 5, 4, 3, 2, 1 };

            selectionsort(arr, 0, 1, 0, arr.Length);

            foreach (var i in arr)
            {

                System.Console.Write(i + " ");
            }

        }
    }
}