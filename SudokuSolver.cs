using System;

namespace Algo
{

    class SudokuSolver
    {

        public static void printboard(int[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    System.Console.Write(board[i, j] + " ");
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine("=================================");
        }

        public static bool isSafe(int r, int c, int num, int[,] board)
        {
            int m = board.GetLength(0);
            int n = board.GetLength(1);
            for (int j = 0; j < n; j++)
            {
                if (board[r, j] == num || board[j, c] == num)
                {
                    return false;
                }
            }
            int gx = (r / 3) * 3;
            int gy = (c / 3) * 3;

            for (int i = gx; i < gx + 3; i++)
            {
                for (int j = gy; j < gy + 3; j++)
                {
                    if (board[i, j] == num)
                    {
                        return false;
                    }
                }
            }
            return true;

        }
        public static bool Sudoku(int r, int c, int[,] sudboard)
        {

            if (r == sudboard.GetLength(0) - 1 && c == sudboard.GetLength(1))
            {
                return true;
            }
            if (c == sudboard.GetLength(1))
            {
                return Sudoku(r + 1, 0, sudboard);

            }

            if (sudboard[r, c] != 0)
            {
                return Sudoku(r, c + 1, sudboard);

            }

            for (int i = 1; i <= 9; i++)
            {
                if (isSafe(r, c, i, sudboard))
                {
                    sudboard[r, c] = i;
                    bool flag = Sudoku(r, c + 1, sudboard);

                    if (flag)
                    {
                        return true;
                    }
                    else
                    {
                        sudboard[r, c] = 0;
                    }

                }


            }
            return false;
        }




        static void Main(string[] args)
        {
            int[,] sudboard = new int[,] {
                 { 5, 3, 0, 0, 7, 0, 0, 0, 0 },
                 { 6, 0, 0, 1, 9, 5, 0, 0, 0 },
                 { 0, 9, 8, 0, 0, 0, 0, 6, 0 },
                 { 8, 0, 0, 0, 6, 0, 0, 0, 3 },
                 { 4, 0, 0, 8, 0, 3, 0, 0, 1 },
                 { 7, 0, 0, 0, 2, 0, 0, 0, 6 },
                 { 0, 6, 0, 0, 0, 0, 2, 8, 0 },
                 { 0, 0, 0, 4, 1, 9, 0, 0, 5 },
                 { 0, 0, 0, 0, 8, 0, 0, 7, 9 }
            };
            System.Console.WriteLine(Sudoku(0, 0, sudboard));
            printboard(sudboard);

        }
    }
}

