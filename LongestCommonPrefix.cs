using System;

namespace Algo
{
    class LongestCommonPrefix
    {
        public static string longcommprefix(string[] strs)
        {
            string ans = "";
            for (int i = 0; i < strs[0].Length; i++)
            {
                char c = strs[0][i];
                foreach (string s in strs)
                {
                    if (i == s.Length || s[i] != c)
                    {
                        return ans;
                    }
                }
                ans += c.ToString();
            }
            return ans;

        }
        static void Main(string[] args)
        {
            System.Console.WriteLine(longcommprefix(new string[] { "ab", "a" }));
        }
    }
}