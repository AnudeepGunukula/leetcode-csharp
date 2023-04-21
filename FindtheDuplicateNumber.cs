using System;

namespace Algo
{

    class FindtheDuplicateNumber
    {
        public static int FindDuplicate(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    return nums[i];
                }

            }
            return -1;
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine(FindDuplicate(new int[] { 1, 3, 4, 2, 2 }));
        }
    }
}