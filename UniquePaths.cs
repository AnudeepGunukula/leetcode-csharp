using System;


namespace Algo
{

    class UniquePaths
    {
        public static int helper(int i, int j, int m, int n, int[,] dp)
        {
            if (i == m - 1 && j == n - 1)
            {
                dp[i, j] = 1;
                return 1;
            }
            if (i == m || j == n)
            {
                return 0;
            }

            if (dp[i, j] == 0)
            {
                dp[i, j] = (helper(i + 1, j, m, n, dp) + helper(i, j + 1, m, n, dp));
            }
            return dp[i, j];




        }
        public static int unique(int m, int n)
        {
            int[,] dp = new int[m, n];
            return helper(0, 0, m, n, dp);

        }
        static void Main(string[] args)
        {
            System.Console.WriteLine(unique(3, 7));
        }
    }
}