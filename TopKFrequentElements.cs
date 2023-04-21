using System;
using System.Collections.Generic;
using System.Linq;

namespace Algo
{
    class TopKFrequentElements
    {
        public static int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (int i in nums)
            {
                if (dict.ContainsKey(i))
                {
                    dict[i]++;
                }
                else
                {
                    dict[i] = 1;
                }
            }
            List<KeyValuePair<int, int>> list = new List<KeyValuePair<int, int>>();
            foreach (var pair in dict)
            {
                list.Add(pair);
            }
            list.Sort((x, y) => y.Value.CompareTo(x.Value));
            int[] res = new int[k];
            for (int i = 0; i < k; i++)
            {
                res[i] = list[i].Key;
            }
            return res;

        }
        static void Main(string[] args)
        {

            int[] ans = TopKFrequent(new int[] { 1, 1, 1, 2, 2, 3 }, 2);
            foreach (int i in ans)
            {
                System.Console.Write(i + " ");
            }

        }
    }
}