using System;

namespace Algo
{

    class MazeWithObstacles
    {

        public static int ways(int x, int y, int r, int c, bool[,] arr, string st)
        {
            int count = 0;
            if (x == r || y == c || arr[x, y] == false)
            {
                return 0;
            }

            if (x == r - 1 && y == c - 1)
            {
                System.Console.WriteLine(st);
                return 1;
            }

            count += (ways(x + 1, y, r, c, arr, st + "D") + ways(x, y + 1, r, c, arr, st + "R"));

            return count;


        }
        static void Main(string[] args)
        {
            bool[,] arr = { { true, true, true, true }, { true, false, true, false }, { true, true, true, true } };
            System.Console.WriteLine(ways(0, 0, arr.GetLength(0), arr.GetLength(1), arr, ""));
        }
    }
}