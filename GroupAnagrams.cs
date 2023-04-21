using System;
using System.Collections.Generic;
namespace Algo
{

    class GroupAnagrams
    {
        public static IList<IList<string>> Anagram(string[] strs)
        {
            IList<IList<string>> ans = new List<IList<string>>();

            Dictionary<string, IList<string>> dict = new Dictionary<string, IList<string>>();
            foreach (string s in strs)
            {
                char[] c = s.ToCharArray();
                Array.Sort(c);
                string t = string.Join("", c);

                if (dict.ContainsKey(t))
                {
                    dict[t].Add(s);
                }
                else
                {
                    dict[t] = new List<string>() { s };
                }

            }
            foreach (var pair in dict)
            {
                ans.Add(pair.Value);
            }
            return ans;

        }
        static void Main(string[] args)
        {
            var ans = Anagram(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });
            foreach (var i in ans)
            {
                System.Console.WriteLine(string.Join(" ", i));
            }

        }
    }
}