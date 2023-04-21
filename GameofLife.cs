using System;

namespace Algo
{
    class GameofLife
    {
        public static int CountNeighbours(int[][] board, int x, int y)
        {
            int count = 0;
            for (int i = Math.Max(x - 1, 0); i <= Math.Min(x + 1, board.Length - 1); i++)
            {
                for (int j = Math.Max(0, y - 1); j <= Math.Min(y + 1, board[0].Length - 1); j++)
                {
                    count += board[i][j] & 1;
                }
            }
            count -= (board[x][y] & 1);
            return count;
        }
        public static void Game(int[][] board)
        {

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    int nei = CountNeighbours(board, i, j);
                    if (board[i][j] == 1)
                    {
                        if (nei == 2 || nei == 3)
                        {
                            board[i][j] = 3;
                        }
                    }
                    else
                    {
                        if (nei == 3)
                        {
                            board[i][j] = 2;
                        }
                    }
                }
            }

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    board[i][j] >>= 1;
                }
            }

        }
        static void Main(string[] args)
        {
            int[][] board = { new int[] { 0, 1, 0 }, new int[] { 0, 0, 1 }, new int[] { 1, 1, 1 }, new int[] { 0, 0, 0 } };
            Game(board);
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    System.Console.Write(board[i][j] + " ");
                }
                System.Console.WriteLine();
            }
        }
    }
}