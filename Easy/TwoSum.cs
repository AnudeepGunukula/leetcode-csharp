using System;
using System.Collections.Generic;
namespace Algo
{
    class TwoSum
    {
        public int[] twosum(int[] nums, int target)
        {

            Dictionary<int, int> mydict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (mydict.ContainsKey(target - nums[i]))
                {
                    return new int[2] { mydict[target - nums[i]], i };
                }
                else
                {
                    mydict[nums[i]] = i;
                }
            }
            return new int[2];
        }

        static void Main(string[] args)
        {
            int target = 6;
            int[] nums = { 3, 2, 4 };

            TwoSum ts = new TwoSum();
            foreach (int i in ts.twosum(nums, target))
            {
                System.Console.Write(i + " ");
            }
        }
    }


}