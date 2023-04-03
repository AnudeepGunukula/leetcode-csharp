using System;

namespace Algo
{

    class CountZerosRecursion
    {

        public static int helper(int n, int count)
        {
            if (n == 0)
            {
                return count;
            }
            if (n % 10 == 0)
            {
                count++;
            }
            return helper(n / 10, count);
        }
        public static int countzeros(int n)
        {
            return helper(n, 0);
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine(countzeros(12031));
        }
    }
}