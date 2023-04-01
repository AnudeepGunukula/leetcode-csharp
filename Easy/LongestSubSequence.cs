using System;

namespace Algo
{

    class LongestSubSequence
    {

        public static int longsubseq(int[] arr)
        {
            int n = arr.Length;
            int[] dp = new int[n];
            dp[0]=1;
            for (int i = 1; i < n; i++)
            {
                dp[i]=1;
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        dp[i] =  Math.Max(1+dp[j], dp[i]);
                    }
                    
                }

            }
            int max=0;
            for(int i=0;i<n;i++){
                if(dp[i]>max){
                    max=dp[i];
                }
            }
            return max;

        }
        static void Main(string[] args)
        {

            System.Console.WriteLine(longsubseq(new int[] { 50, 4, 10, 8, 30, 100,2}));


        }
    }
}