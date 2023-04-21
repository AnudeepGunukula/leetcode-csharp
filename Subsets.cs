using System;
using System.Linq;
using System.Collections.Generic;
namespace Algo
{

    class Subsets

    {
        public static void helper(int[] pr, int[] un, IList<IList<int>> llist)
        {
            if (un.GetLength(0) == 0)
            {
                llist.Add(pr);
                return;
            }
            helper(pr.Concat(new int[] { un[0] }).ToArray(), un[1..], llist);
            helper(pr, un[1..], llist);
        }
        public static IList<IList<int>> subset(int[] nums)
        {
            IList<IList<int>> llist = new List<IList<int>>();
            helper(new int[] { }, nums, llist);

            return llist;

        }

        static void Main(string[] args)
        {
            IList<IList<int>> ans = subset(new int[] { 1, 2, 3 });
            foreach (var list in ans)
            {
                System.Console.WriteLine(string.Join(',', list));
            }

        }
    }
}