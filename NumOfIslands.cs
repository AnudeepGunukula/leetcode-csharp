using System;
using System.Collections.Generic;

namespace Algo
{
    public class pair
    {
        public int i;
        public int j;
        public pair(int i, int j)
        {
            this.i = i;
            this.j = j;
        }
    }
    class NumOfIslands
    {

        public static void bfs(char[][] grid, int i, int j)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            Queue<pair> q = new Queue<pair>();
            q.Enqueue(new pair(i, j));
            grid[i][j] = '0';
            while (q.Count > 0)
            {
                var x = q.Dequeue();
                int r = x.i;
                int c = x.j;
                if (r + 1 < m && grid[r + 1][c] == '1')
                {
                    q.Enqueue(new pair(r + 1, c));
                    grid[r + 1][c] = '0';
                }
                if (r - 1 >= 0 && grid[r - 1][c] == '1')
                {
                    q.Enqueue(new pair(r - 1, c));
                    grid[r - 1][c] = '0';
                }
                if (c + 1 < n && grid[r][c + 1] == '1')
                {
                    q.Enqueue(new pair(r, c + 1));
                    grid[r][c + 1] = '0';
                }
                if (c - 1 >= 0 && grid[r][c - 1] == '1')
                {
                    q.Enqueue(new pair(r, c - 1));
                    grid[r][c - 1] = '0';
                }

            }
        }

        public static void dfs(char[][] grid, int r, int c)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            grid[r][c] = '0';
            if (r - 1 >= 0 && grid[r - 1][c] == '1')
            {
                dfs(grid, r - 1, c);
            }
            if (r + 1 < m && grid[r + 1][c] == '1')
            {
                dfs(grid, r + 1, c);
            }
            if (c - 1 >= 0 && grid[r][c - 1] == '1')
            {
                dfs(grid, r, c - 1);
            }
            if (c + 1 < n && grid[r][c + 1] == '1')
            {
                dfs(grid, r, c + 1);
            }
        }


        public static int numofIslandInPlace(char[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            int count = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        dfs(grid, i, j);
                        count += 1;
                    }
                }
            }
            return count;



        }

        static void Main(string[] args)
        {
            char[][] grid ={
                    new char[]{'1','1','0','0','0'},
                    new char[]{'1','1','0','0','0'},
                    new char[]{'0','0','1','0','0'},
                    new char[]{'0','0','0','1','1'}
            };
            System.Console.WriteLine(numofIslandInPlace(grid));

        }

    }
}