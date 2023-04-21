using System;

namespace Algo
{

    class NKnightBack
    {
        public static bool isSafe(int r, int c, int[,] board)
        {


            if (r - 2 >= 0 && c - 1 >= 0 && board[r - 2, c - 1] == 1)
            {
                return false;
            }
            if (r - 2 >= 0 && c + 1 < board.GetLength(1) && board[r - 2, c + 1] == 1)
            {
                return false;
            }
            if (r - 1 >= 0 && c - 2 >= 0 && board[r - 1, c - 2] == 1)
            {
                return false;
            }
            if (r - 1 >= 0 && c + 2 < board.GetLength(1) && board[r - 1, c + 2] == 1)
            {
                return false;
            }

            return true;

        }

        public static void printboard(int[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    System.Console.Write(board[i, j]);
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine("===============");
        }
        public static void Nknight(int r, int c, int[,] board, int knigts)
        {
            if (knigts == 0)
            {
                printboard(board);
            }

            if (r == board.GetLength(0) - 1 && c == board.GetLength(1))
            {
                return;
            }

            if (c == board.GetLength(1))
            {
                Nknight(r + 1, 0, board, knigts);
                return;

            }

            if (isSafe(r, c, board))
            {
                board[r, c] = 1;
                Nknight(r, c + 1, board, knigts - 1);
                board[r, c] = 0;
            }

            Nknight(r, c + 1, board, knigts);

        }
        static void Main(string[] args)
        {
            int n = 4;
            int knigts = 4;
            int[,] board = new int[n, n];
            Nknight(0, 0, board, knigts);

        }
    }
}