using System;

namespace Algo
{

    class MoveZeros
    {

        public static void movzeros(int[] nums)
        {
            int j = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    (nums[i], nums[j]) = (nums[j], nums[i]);
                    j++;
                }


            }

        }
        static void Main(string[] args)
        {
            int[] nums = new int[] { 0, 1, 0, 3, 12 };
            movzeros(nums);
            foreach (int i in nums)
            {
                System.Console.Write(i + " ");
            }
            System.Console.WriteLine();

        }
    }
}