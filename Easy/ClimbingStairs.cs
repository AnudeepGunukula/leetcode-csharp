using System;

namespace Algo
{

    class ClimbingStairs
    {
        public static int ClimbStairs(int n)
        {
            int[] dp = new int[n + 1];
            if (n <= 2)
            {
                return n;
            }
            dp[0] = 0;
            dp[1] = 1;
            dp[2] = 2;
            for (int i = 3; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            return dp[n];

        }


        static void Main(string[] args)
        {
          System.Console.WriteLine(ClimbStairs(5));
        }
    }
}