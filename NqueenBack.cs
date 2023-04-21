using System;

namespace Algo
{

    class NqueenBack
    {
        public static bool IsSafe(int r, int c, int[,] board)
        {
            int x = r, y = c;

            for (int i = 0; i < r; i++)
            {
                if (board[i, c] == 1)
                {
                    return false;

                }
            }
            while (x >= 0 && y >= 0)
            {
                if (board[x, y] == 1)
                {
                    return false;
                }
                x--;
                y--;
            }
            x = r;
            y = c;

            while (x >= 0 && y < board.GetLength(1))
            {
                if (board[x, y] == 1)
                {
                    return false;
                }
                x--;
                y++;
            }
            return true;
        }
        public static void PrintBoard(int[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == 1)
                    {
                        System.Console.Write("Q ");
                    }
                    else
                    {
                        System.Console.Write("X ");
                    }

                }
                System.Console.WriteLine("");
            }
            System.Console.WriteLine("=============");
        }
        public static int Nqueen(int row, int[,] board)
        {
            int count = 0;
            if (row == board.GetLength(0))
            {
                PrintBoard(board);
                count++;
                return count;
            }

            for (int col = 0; col < board.GetLength(1); col++)
            {
                if (IsSafe(row, col, board))
                {
                    board[row, col] = 1;
                    count += Nqueen(row + 1, board);
                    board[row, col] = 0;
                }
            }
            return count;

        }
        static void Main(string[] args)
        {
            int n = 5;
            int[,] board = new int[n, n];
            System.Console.WriteLine($"No. of Possibilities {Nqueen(0, board)}");


        }
    }
}