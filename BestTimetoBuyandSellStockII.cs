using System;

namespace Algo
{
    class BestTimetoBuyandSellStockII
    {
        public static int MaxProfit(int[] prices)
        {
            int profit = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                if (prices[i] < prices[i + 1])
                    profit += (prices[i + 1] - prices[i]);
            }
            return profit;
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine(MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 }));
        }
    }
}