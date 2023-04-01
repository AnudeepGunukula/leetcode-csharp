using System;
using System.Collections.Generic;
namespace Algo
{

    class RemoveDuplicatesFromSortedArray
    {




        public static int RemoveDuplicates(int[] nums)
        {
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[j] != nums[i])
                {
                    nums[++j] = nums[i];

                }
            }
            System.Console.WriteLine(j+1);
            foreach (int i in nums)
            {
                System.Console.WriteLine(i);
            }

            return 0;
        }



        static void Main(string[] args)
        {
            System.Console.WriteLine(RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }));
        }



    }


}