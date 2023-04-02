using System;

namespace Algo
{
    class CountNoOfStepsRecursion
    {

        public static int helper(int num, int count)
        {

            if (num == 0)
            {
                return count;
            }
            if (num % 2 == 0)
            {
                return helper(num / 2, count + 1);

            }
            else
            {
                return helper(num - 1, count + 1);
            }
        }
        public static int numofsteps(int num)
        {
            return helper(num, 0);

        }
        static void Main(string[] args)
        {
            System.Console.WriteLine(numofsteps(14));
        }
    }
}