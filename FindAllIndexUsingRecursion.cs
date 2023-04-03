using System;
using System.Collections.Generic;
namespace Algo
{

    class FindAllIndexUsingRecursion
    {

        public static void findallind(int[] arr, int key, int i, List<int> res)
        {
            if (arr[i] == key)
            {
                res.Add(i);
            }
            if (i == arr.Length - 1)
            {
                return;
            }
            findallind(arr, key, i + 1, res);


        }

        public static List<int> findallindwithoutlistarg(int[] arr, int key, int i)
        {
            List<int> res = new List<int>();
            if (arr[i] == key)
            {
                res.Add(i);
            }
            if (i == arr.Length - 1)
            {
                return res;
            }

            List<int> temp = findallindwithoutlistarg(arr, key, i + 1);
            if (temp.Count != 0)
            {
                res.AddRange(temp);
            }
            return res;

        }

        static void Main(string[] args)
        {
            //List<int> res = new List<int>();
            //findallind(new int[] { 42, 32, 23, 45, 32, 77, 65, 32 }, 32, 0, res);
            List<int> ans = findallindwithoutlistarg(new int[] { 42, 32, 23, 45, 32, 77, 65, 32 }, 32, 0);

            foreach (var i in ans)
            {
                System.Console.Write(i + " ");
            }

            // foreach (var i in res)
            // {
            //     System.Console.Write(i + " ");
            // }

        }
    }

}