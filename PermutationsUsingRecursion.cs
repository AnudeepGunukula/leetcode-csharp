using System;
using System.Collections.Generic;
namespace Algo
{

    class PermutationsUsingRecursion
    {

        public static List<string> perm(string pr, string up)
        {
            List<string> ans = new List<string>();
            if (up == "")
            {
                ans.Add(pr);
                return ans;
            }
            for (int i = 0; i <= pr.Length; i++)
            {
                ans.AddRange(perm(pr[0..i] + up[0] + pr[i..], up[1..]));
            }
            return ans;
        }

        public static int count_perm(string pr, string up)
        {
            int count = 0;
            if (up == "")
            {
                count++;
                return count;
            }
            for (int i = 0; i <= pr.Length; i++)
            {
                count += count_perm(pr[0..i] + up[0] + pr[i..], up[1..]);
            }
            return count;
        }



        static void Main(string[] args)
        {
            int ans = count_perm("", "abcd");

            System.Console.WriteLine(ans);

        }
    }
}