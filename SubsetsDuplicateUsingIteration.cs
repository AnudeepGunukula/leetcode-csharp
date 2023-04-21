using System;
using System.Collections.Generic;

namespace Algo
{

    class SubsetsDuplicateUsingIteration
    {


        public static List<List<int>> subsetdup(int[] arr)
        {
            Array.Sort(arr);

            List<List<int>> olist = new List<List<int>>() { new List<int>() { } };
            int start;

            for (int x = 0; x < arr.Length; x++)
            {
                int n = olist.Count;
                start = 0;
                if (x > 0 && (arr[x] == arr[x - 1]))
                {
                    start = n / 2;
                }

                for (int i = start; i < n; i++)
                {
                    List<int> ilist = new List<int>(olist[i]);
                    ilist.Add(arr[x]);
                    olist.Add(ilist);
                }
            }
            return olist;

        }
        static void Main(string[] args)
        {
            var ans = subsetdup(new int[] { 2, 1, 2 });
            foreach (var list in ans)
            {
                list.ForEach(i => Console.Write(i + " "));
                System.Console.WriteLine();
            }

        }
    }
}