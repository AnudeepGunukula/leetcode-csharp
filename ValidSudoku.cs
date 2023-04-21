using System;

namespace Algo
{
    class ValidSudoku
    {

        public static bool CanPlace(char[][] board, int r, int c, int number)
        {
            System.Console.WriteLine(number);
            char num = (char)(number + '0');
            int m = board.Length;
            int n = board[0].Length;

            for (int i = 0; i < m; i++)
            {
                if (board[r][i] == num || board[i][c] == num)
                {
                    System.Console.WriteLine($"returning false bcz either {board[r][i]} or {board[i][c]} equals {num}"); 
                    return false;
                }
            }
            int gsx = (r / 3) * 3;
            int gsy = (c / 3) * 3;
            for (int i = gsx; i < gsx + 3; i++)
            {
                for (int j = gsy; j < gsy + 3; j++)
                {
                    if (board[i][j] == num)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool helper(char[][] board, int r, int c)
        {
            System.Console.WriteLine(r + " " + c);
            if ((r == board.Length - 1) && (c == board[0].Length))
            {
                return true;
            }
            if (c == board[0].Length)
            {
                return helper(board, r + 1, 0);
            }
            if (board[r][c] != '.')
            {
                return helper(board, r, c + 1);
            }
            for (int i = 1; i <= 9; i++)
            {



                if (CanPlace(board, r, c, i))
                {
                    System.Console.WriteLine("enter");
                    printboard(board);
                    System.Console.WriteLine("------------------------");
                    char ans = (char)(i + '0');
                    board[r][c] = ans;
                    bool flag = helper(board, r, c + 1);
                    if (flag == true)
                    {
                        return true;
                    }
                    else
                    {
                        board[r][c] = '.';
                    }

                }
            }
            return false;
        }

        public static bool ValidSudokuOrNot(char[][] board)
        {

            return helper(board, 0, 0);

        }
        public static void printboard(char[][] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    System.Console.Write(board[i][j] + " ");
                }
                System.Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            char[][] board =
            {
                new char[] { '.', '8', '7', '6', '5', '4', '3', '2', '1' },
                new char[] { '2', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '3', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '4', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '5', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '6', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '7', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '8', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '9', '.', '.', '.', '.', '.', '.', '.', '.' }
            };


            System.Console.WriteLine(ValidSudokuOrNot(board));
            printboard(board);
        }
    }
}