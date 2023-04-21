using System;

using System.Collections.Generic;

namespace Algo
{

    class FoursumII
    {
        public static int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4)
        {
            int count = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums2.Length; j++)
                {
                    int key = nums1[i] + nums2[j];
                    if (dict.ContainsKey(key))
                    {
                        dict[key] += 1;
                    }
                    else
                    {
                        dict[key] = 1;
                    }
                }
            }

            for (int i = 0; i < nums3.Length; i++)
            {
                for (int j = 0; j < nums4.Length; j++)
                {
                    int key = nums3[i] + nums4[j];

                    if (dict.ContainsKey(-(key)))
                    {

                        count += dict[-(key)];
                    }
                }
            }

            return count;
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine(FourSumCount(new int[] { 1, 2 }, new int[] { -2, -1 }, new int[] { -1, 2 }, new int[] { 0, 2 }));

        }
    }
}