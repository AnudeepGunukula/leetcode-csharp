using System;

namespace Algo
{

    class MazeRecursion
    {
        public static void printmatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    System.Console.Write(matrix[i, j] + " ");
                }
                System.Console.WriteLine();
            }

        }
        public static int ways4dir(int x, int y, int n, string st, bool[,] visited, int[,] matrix, int level)
        {

            int count = 0;
            if (x >= n || y >= n || x < 0 || y < 0 || !visited[x, y])
            {
                return 0;
            }
            if (x == n - 1 && y == n - 1)
            {
                matrix[x, y] = level;
                printmatrix(matrix);
                System.Console.WriteLine(st);
                System.Console.WriteLine("---------------");
                matrix[x, y] = 0;
                return 1;
            }
            matrix[x, y] = level;

            visited[x, y] = false;
            count += (ways4dir(x + 1, y, n, st + "D", visited, matrix, level + 1) + ways4dir(x, y + 1, n, st + "R", visited, matrix, level + 1) + ways4dir(x - 1, y, n, st + "U", visited, matrix, level + 1) + ways4dir(x, y - 1, n, st + "L", visited, matrix, level + 1));
            visited[x, y] = true;

            matrix[x, y] = 0;
            return count;

        }

        public static int ways(int x, int y, int n, string st)
        {
            int count = 0;
            if (x == n || y == n)
            {
                return 0;
            }
            if (x == n - 1 && y == n - 1)
            {
                System.Console.WriteLine(st);
                count++;
                return count;
            }

            count += (ways(x + 1, y, n, st + "D") + ways(x, y + 1, n, st + "R") + ways(x + 1, y + 1, n, st + "X"));
            return count;

        }

        static void Main(string[] args)
        {
            int[,] matrix = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };

            bool[,] visited = { { true, true, true }, { true, true, true }, { true, true, true } };
            System.Console.WriteLine(ways4dir(0, 0, 3, "", visited, matrix, 1));
        }
    }
}