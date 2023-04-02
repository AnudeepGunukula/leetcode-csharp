using System;

namespace Algo
{
    class ReverseNumberUsingRecursion
    {


        public static int helper(int n, int ans)
        {
            if (n == 0)
            {
                return ans;
            }
            int rem = n % 10;
            ans = ans * 10 + rem;
            return helper(n / 10, ans);
        }
        public static int reverse(int n)
        {

            return helper(n, 0);


        }
        static void Main(string[] args)
        {
            System.Console.WriteLine(reverse(1234));

        }
    }
}