using System;

namespace Algo
{
    class MergeSortedArray
    {

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] ans = new int[m + n];
            int i = 0;
            int j = 0;
            int index = 0;
            while (i < m && j < n)
            {
                if (nums1[i] < nums2[j])
                {
                    ans[index] = nums1[i];
                    i++;
                }
                else
                {
                    ans[index] = nums2[j];
                    j++;

                }
                index++;

            }

            while (i < m)
            {
                ans[index++] = nums1[i++];
            }
            while (j < n)
            {
                ans[index++] = nums2[j++];
            }

            for (int x = 0; x < nums1.Length; x++)
            {
                nums1[x] = ans[x];
            }

        }
        static void Main(string[] args)
        {
            int[] nums1 = new int[6] { 1, 2, 3, 0, 0, 0 };
            Merge(nums1, 3, new int[3] { 2, 5, 6 }, 3);

            for (int i = 0; i < nums1.Length; i++)
            {
                System.Console.WriteLine(nums1[i]);
            }

        }
    }
}