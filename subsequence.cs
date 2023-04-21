using System;
using System.Collections.Generic;
namespace Algo
{
    class subsequence
    {

        public static List<string> subseq(string pr, string un)
        {

            List<string> ans = new List<string>();
            if (un == "")
            {
                ans.Add(pr);
                return ans;
            }
            ans.AddRange(subseq(pr + un[0], un.Substring(1)));

            ans.AddRange(subseq(pr, un.Substring(1)));

            return ans;



        }
        static void Main(string[] args)
        {
            List<string> ans = subseq("", "abc");
            //ans.Sort();
            foreach (var i in ans)
            {
                System.Console.WriteLine(i);
            }





        }
    }
}