using System;
using System.Collections.Generic;
namespace Algo
{
    class SubsetsUsingIteration
    {

        public static List<List<int>> subsets(int[] arr)
        {
            List<List<int>> olist = new List<List<int>>() { new List<int>() { } };

            foreach (int num in arr)
            {
                int n = olist.Count;

                for (int i = 0; i < n; i++)
                {
                    List<int> ilist = new List<int>(olist[i]);
                    ilist.Add(num);
                    olist.Add(ilist);
                }
            }


            return olist;

        }
        static void Main(string[] args)
        {

            var ans = subsets(new int[] { 1, 2, 3 });
            foreach (var x in ans)
            {
                x.ForEach(i => System.Console.Write(i + ","));
                System.Console.WriteLine();
            }

        }
    }
}