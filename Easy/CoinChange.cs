using System;

namespace Algo
{

    class CoinChange
    {

        public static int coinchg(int n, int[] arr)
        {

            int[] dp = new int[n + 1];
            dp[0] = 0;
            for (int i = 1; i <= n; i++)
            {
                foreach (int j in arr)
                {
                    if (i - j >= 0)
                    {
                        dp[i] = 1 + Math.Min(dp[i - j], dp[i]);
                    }

                }
            }
            return dp[n];
        }


        static void Main(string[] args)
        {

            System.Console.WriteLine(coinchg(4, new int[]{ 1,3,7,10}));


        }
    }
}