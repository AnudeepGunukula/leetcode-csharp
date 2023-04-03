using System;

namespace Algo
{

    class ValidAnagram
    {

        public static bool isanagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            int[] freq = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                freq[s[i] - 'a']++;
                freq[t[i] - 'a']--;
            }

            for (int i = 0; i < 26; i++)
            {
                if (freq[i] != 0)
                {
                    return false;
                }
            }

            return true;
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine(isanagram("anagram", "anagram"));

        }
    }
}