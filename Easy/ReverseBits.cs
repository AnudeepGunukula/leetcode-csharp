using System;
namespace Algo
{

    class ReverseBits
    {


        public static bool setbit(uint n, int i)
        {
             if((n & (1<<i))!=0){
                return true;
             }
             return false;
        }

        public static uint RevBits(uint n)
        {

            int ans = 0;

            for (int i = 0; i < 32; i++)
            {
                if (setbit(n, i))
                {
                    ans = ans | (1 << (31 - i));
                }
            }
            return Convert.ToUInt32(ans);
        }

        static void Main(string[] args)
        {
            uint n = Convert.ToUInt32("00000010100101000001111010011100", 2);
           
           System.Console.WriteLine(RevBits(n));
        }
    }
}