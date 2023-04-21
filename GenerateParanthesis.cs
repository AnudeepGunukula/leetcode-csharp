using System;
using System.Collections.Generic;
namespace Algo
{

    class GenerateParanthesis
    {
        public static void helper(int open, int close, string st, IList<string> list)
        {
            if (open == 0 && close == 0)
            {
                list.Add(st);
                return;
            }
            if (open > 0)
            {
                helper(open - 1, close, st + "(", list);
            }
            if (close > open)
            {
                helper(open, close - 1, st + ")", list);
            }
        }
        public static IList<string> GenPar(int n)
        {
            IList<string> list = new List<string>();
            helper(n, n, "", list);
            return list;
        }
        static void Main(string[] args)
        {
            var ans = GenPar(3);
            System.Console.WriteLine(string.Join('\n', ans));

        }
    }
}