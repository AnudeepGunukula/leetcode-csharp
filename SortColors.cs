using System;

namespace Algo
{
    class SortColors
    {

        public static void SortColorsUsingDutchNationalFlag(int[] nums)
        {
            int low = 0, mid = 0, high = nums.Length - 1;

            while (mid <= high)
            {
                if (nums[mid] == 0)
                {
                    (nums[mid], nums[low]) = (nums[low], nums[mid]);
                    low++;
                    mid++;
                }
                else if (nums[mid] == 1)
                {
                    mid++;
                }
                else if (nums[mid] == 2)
                {
                    (nums[mid], nums[high]) = (nums[high], nums[mid]);
                    high--;
                }
            }

        }

        public static void SortColorsUsingCountSort(int[] nums)   //O(2N)
        {
            int[] count = new int[3];
            foreach (int i in nums)
            {
                count[i]++;
            }

            int x = 0;
            for (int i = 0; i < count.Length; i++)
            {
                for (int j = 0; j < count[i]; j++)
                {
                    nums[x++] = i;
                }
            }

        }
        static void Main(string[] args)
        {
            int[] ans = new int[] { 2, 0, 2, 1, 1, 0 };

            // SortColorsUsingCountSort(ans);

            SortColorsUsingDutchNationalFlag(ans);

            System.Console.WriteLine(string.Join(",", ans));

        }
    }
}