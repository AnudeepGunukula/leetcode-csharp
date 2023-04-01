using System;
using System.Collections.Generic;
namespace Algo
{

    class HappyNumber
    {

        public static int sumofsq(int n)
        {
            int ans = 0;
            while (n > 0)
            {
                int rem = n % 10;
                ans += (int)Math.Pow(rem, 2);
                n=n/10;
            }
            return ans;
        }
        public static bool IsHappy(int n)
        {
            HashSet<int> set = new HashSet<int>();

            while (!set.Contains(n))
            {
                set.Add(n);
                n = sumofsq(n);

                if (n == 1)
                {
                    return true;
                }

               
            }


            return false;

        }
        static void Main(string[] args)
        {
            System.Console.WriteLine(IsHappy(2));

        }
    }
}