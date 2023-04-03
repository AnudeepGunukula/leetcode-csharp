using System;
using System.Collections.Generic;
namespace Algo
{

    class MajorityElement
    {

        public static int majele(int[] nums)
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

            foreach (var pair in dict)
            {
                if (pair.Value > nums.Length / 2)
                {
                    return pair.Key;
                }
            }
            return 0;



        }
        static void Main(string[] args)
        {
            System.Console.WriteLine(majele(new int[] { 3, 2, 3 }));
        }
    }
}