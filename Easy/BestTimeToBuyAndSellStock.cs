using System;

namespace Algo
{
    class BestTimeToBuyAndSellStock
    {

        public static int MaxProfit(int[] prices)
        {
            int maxpro = 0, curmin = prices[0];
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < curmin)
                {
                    curmin = prices[i];
                }
                if (prices[i] - curmin > maxpro)
                {
                    maxpro = prices[i] - curmin;
                }
            }

            return maxpro;
        }
        static void Main(string[] args)
        {
           System.Console.WriteLine(MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 }));

        }

    }

}