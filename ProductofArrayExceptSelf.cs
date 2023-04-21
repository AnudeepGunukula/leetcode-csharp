using System;

namespace Algo
{
    class ProductofArrayExceptSelf
    {

        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] left = new int[nums.Length];
            left[0] = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                left[i] = nums[i - 1] * left[i - 1];
            }

            int[] right = new int[nums.Length];
            right[nums.Length - 1] = 1;

            for (int i = nums.Length - 2; i >= 0; i--)
            {
                right[i] = nums[i + 1] * right[i + 1];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = left[i] * right[i];
            }
            return nums;

        }
        static void Main(string[] args)
        {
            System.Console.WriteLine(string.Join(",", ProductExceptSelf(new int[] { -1, 1, 0, -3, 3 })));
        }
    }
}