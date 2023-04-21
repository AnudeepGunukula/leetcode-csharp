using System;
using System.Collections.Generic;
namespace Algo
{

    class PalindromePartitioning
    {

        public static bool IsPalindrome(string s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        public static void helper(string pr, string un, List<string> list, IList<IList<string>> res)
        {
            if (!IsPalindrome(pr))
            {
                return;
            }

            if (un == "")
            {
                list.Add(pr);
                res.Add(new List<string>(list));
                list.RemoveAt(list.Count - 1);
                return;
            }


            if (IsPalindrome(pr))
            {
                for (int i = 0; i < un.Length; i++)
                {
                    if (pr != "")
                    {
                        list.Add(pr);
                    }
                    helper(un[..(i + 1)], un[(i + 1)..], list, res);
                    if (pr != "")
                    {
                        list.RemoveAt(list.Count - 1);
                    }
                }


            }


        }

        public static IList<IList<string>> Partition(string s)
        {
            IList<IList<string>> llist = new List<IList<string>>();
            helper("", s, new List<string>(), llist);
            return llist;
        }
        static void Main(string[] args)
        {
            var ans = Partition("cbbbcc");
            foreach (var list in ans)
            {
                System.Console.WriteLine(string.Join(",", list));
            }

            //   ["c", "b", "b", "b", "c", "c"]
            //   ["c", "b", "b", "b", "cc"]
            //   ["c", "b", "bb", "c", "c"]
            //   ["c", "b", "bb", "cc"]
            //   ["c", "bb", "b", "c", "c"]
            //   ["c", "bb", "b", "cc"]
            //   ["c", "bbb", "c", "c"]
            //   ["c", "bbb", "cc"]
            //   ["cbbbc", "c"]
        }
    }
}