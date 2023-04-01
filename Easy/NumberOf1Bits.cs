using System;

namespace Algo
{
    class NumberOf1Bits
    {
        public static int HammingWeight(uint n)
        {
            int count = 0;
            while (n > 0)
            {
                if ((n & 1) == 1)
                {
                    count++;

                }
                n >>= 1;
            }
            return count;
        }
        static void Main(string[] args)
        {
            uint n = (uint)Convert.ToInt32("00000000000000000000000000001011", 2);
            System.Console.WriteLine(HammingWeight(n));


        }
    }
}