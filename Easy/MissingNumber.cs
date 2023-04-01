using System;
using System.Linq;
namespace Algo
{


    class MissingNumber
    {

        public static int missnum(int[] nums)
        {
            int n = nums.Length;
            int exp_sum = (n * (n + 1)) / 2;
            int act_sum = 0;
            for (int i = 0; i <n; i++)
            {
               act_sum+=nums[i];
            }

            return exp_sum-act_sum;

        }
        static void Main(string[] args)
        {

            System.Console.WriteLine(missnum(new int[] { 0, 1 }));

        }
    }
}