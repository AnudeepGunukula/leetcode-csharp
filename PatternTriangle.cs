using System;

namespace Algo
{


    class PatternTriangle
    {

        public static void PrintInvTriangle(int r, int c)
        {
            if (r == 0)
            {
                return;
            }

            if (r == c)
            {
                PrintInvTriangle(r - 1, 0);
                System.Console.WriteLine();


            }
            if (r > c)
            {
                PrintInvTriangle(r, c + 1);
                System.Console.Write("* ");


            }


        }
        static void Main(string[] args)
        {
            PrintInvTriangle(5, 0);
        }
    }
}