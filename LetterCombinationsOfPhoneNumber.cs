using System;
using System.Collections.Generic;
namespace Algo
{

    class LetterCombinationsOfPhoneNumber
    {

        public static void helper(string pr, string un, Dictionary<char, string> dict, List<string> ans)
        {

            if (un == "")
            {
                ans.Add(pr);
                return;

            }

            foreach (var i in dict[un[0]])
            {
                helper(pr + i, un[1..], dict, ans);
            }

        }
        public static List<string> letterComb(string digits)
        {
            Dictionary<char, string> dict = new Dictionary<char, string>() { { '2', "abc" }, { '3', "def" }, { '4', "ghi" }, { '5', "jkl" }, { '6', "mno" }, { '7', "pqrs" }, { '8', "tuv" }, { '9', "wxyz" } };
            List<string> ans = new List<string>();
            helper("", digits, dict, ans);
            return ans;
        }
        static void Main(string[] args)
        {
            List<string> ans = letterComb("23");
            foreach (var i in ans)
            {
                System.Console.WriteLine(i);
            }


        }
    }
}