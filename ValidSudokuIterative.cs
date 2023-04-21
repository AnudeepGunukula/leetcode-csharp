//here the intution is not to solve the sudoku board just to prove whether it is valid or not
// for that we can actually use the existing elements no need of new elements to addd
// we just check wether the existing elements match the sudoku rules and then just return false or true

// [["8","3",".",  ".","7",".",".",".","."]
// ,["6",".",".",  "1","9","5",".",".","."]
// ,[".","9","8",  ".",".",".",".","6","."]

// ,["8",".",".",".","6",".",".",".","3"]
// ,["4",".",".","8",".","3",".",".","1"]
// ,["7",".",".",".","2",".",".",".","6"]
// ,[".","6",".",".",".",".","2","8","."]
// ,[".",".",".","4","1","9",".",".","5"]
// ,[".",".",".",".","8",".",".","7","9"]]

//  Since there are two 8's in the top left 3x3 sub-box, it is invalid so we return false;

using System;
using System.Collections.Generic;
namespace Algo
{

    class ValidSudokuIterative
    {
        public static bool IsValidSudoku(char[][] board)
        {
            HashSet<string> seen = new HashSet<string>();

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] != '.')
                    {
                        if (!seen.Add($"{board[i][j]} at row {i}") ||
                            !seen.Add($"{board[i][j]} at col {j}") ||
                            !seen.Add($"{board[i][j]} at grid {i / 3}x{j / 3}"))
                        {
                            return false;
                        }



                    }
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            char[][] board ={
                    new char[]{'8','3','.','.','7','.','.','.','.'},
                    new char[]{'6','.','.','1','9','5','.','.','.'}
                    ,new char[]{'.','9','8','.','.','.','.','6','.'}
                    ,new char[]{'8','.','.','.','6','.','.','.','3'}
                    ,new char[]{'4','.','.','8','.','3','.','.','1'}
                    ,new char[]{'7','.','.','.','2','.','.','.','6'}
                    ,new char[]{'.','6','.','.','.','.','2','8','.'}
                    ,new char[]{'.','.','.','4','1','9','.','.','5'}
                    ,new char[]{'.','.','.','.','8','.','.','7','9'}
           };
            System.Console.WriteLine(IsValidSudoku(board));
        }
    }
}