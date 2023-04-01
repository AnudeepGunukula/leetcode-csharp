using System;

namespace Algo
{

    class FindIndexOfFirstOccurence
    {

        public static bool check(int ind, string haystack, string needle)
        {
            for (int i = 0; i < needle.Length; i++)
            {
                if (haystack[ind++] != needle[i])
                {
                    return false;
                }
            }
            return true;
        }
        public static int StrStr(string haystack, string needle)
        {
            int hl = haystack.Length, nl = needle.Length;

            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0])
                {
                    if ((hl - i >= nl) && check(i, haystack, needle))
                    {

                        return i;
                    }
                }
            }
            return -1;

        }
        static void Main(string[] args)
        {

            System.Console.WriteLine(StrStr("sadbutsad", "sad"));

        }
    }
}