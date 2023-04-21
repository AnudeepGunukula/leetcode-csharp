using System;
using System.Linq;
using System.Collections.Generic;

namespace Algo
{
    class Permutations
    {
        public static void helper(int[] pr, int[] un, IList<IList<int>> llist)
        {
            if (un.GetLength(0) == 0)
            {
                llist.Add(pr);
                return;
            }
            int n = pr.GetLength(0);
            for (int i = 0; i <= n; i++)
            {
                int[] arr = pr[0..i].Concat(new int[] { un[0] }).Concat(pr[i..]).ToArray();
                helper(arr, un[1..], llist);

            }

        }

        public static IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> llist = new List<IList<int>>();
            helper(new int[] { }, nums, llist);
            return llist;


        }
        static void Main(string[] args)
        {

            IList<IList<int>> ans = Permute(new int[] { 1, 2, 3 });
            foreach (var list in ans)
            {
                System.Console.WriteLine(string.Join(',', list));
            }


        }
    }
}