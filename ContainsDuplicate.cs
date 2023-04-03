using System;
using System.Collections.Generic;
namespace Algo
{


    class ContainsDuplicate
    {


        public static bool containsdup(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();

            foreach (int i in nums)
            {
                if (set.Contains(i))
                {
                    return true;
                }
                set.Add(i);
            }

            return false;


        }

        static void Main(string[] args)
        {
            System.Console.WriteLine(containsdup(new int[] { 1, 2, 3, 1 }));

        }
    }
}