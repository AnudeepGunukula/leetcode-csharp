using System;

namespace Algo
{

    class FindtheDuplicateNumberSlowFast
    {
        public static int FindDuplicate(int[] nums)
        {
            int slow = nums[0];
            int fast = nums[0];

            do
            {
                slow = nums[slow];
                fast = nums[nums[fast]];

            } while (slow != fast);

            fast = nums[0];

            while (slow != fast)
            {
                fast = nums[fast];
                slow = nums[slow];
            }
            return slow;


        }
        static void Main(string[] args)
        {
            System.Console.WriteLine(FindDuplicate(new int[] { 1, 3, 4, 2, 2 }));
        }
    }
}