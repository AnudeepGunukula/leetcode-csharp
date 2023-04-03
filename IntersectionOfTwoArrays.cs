using System;
using System.Collections.Generic;
namespace Algo
{
    class IntersectionOfTwoArrays
    {

        public static int[] Intersect(int[] nums1, int[] nums2)
        {

            List<int> list = new List<int>();
            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (int i in nums1)
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

            foreach (int i in nums2)
            {
                if (dict.ContainsKey(i) && dict[i] != 0)
                {
                    dict[i] -= 1;
                    list.Add(i);
                }
            }


            return list.ToArray();


        }
        static void Main(string[] args)
        {
            int[] arr = Intersect(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 });
            foreach (int i in arr)
            {
                System.Console.WriteLine(i + " ");
            }
        }
    }
}