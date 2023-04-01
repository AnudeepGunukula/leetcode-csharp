using System;

namespace Algo
{
    class PowersOfThree
    {

        public static bool IsPowerOfThree(int n)
        {
            if (n == 0)
            {
                return false;
            }

            while (n % 3 == 0)
            {

                n /= 3;
            }
            return n == 1;

        }
        static void Main(string[] args)
        {
            System.Console.WriteLine(IsPowerOfThree(27));

        }
    }
}