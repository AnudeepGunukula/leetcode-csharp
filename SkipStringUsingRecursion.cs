using System;
namespace Algo
{

    class SkipStringUsingRecursion
    {

        public static bool IsSubString(string st, int i, string key)
        {
            if (i + key.Length > st.Length)
            {
                return false;
            }
            else
            {
                for (int x = 0; x < key.Length; x++)
                {
                    if (st[i++] != key[x])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static string skipA(string st, int i, string skipstr)
        {
            string ans = "";

            if (i == st.Length)
            {
                return ans;
            }
            if (IsSubString(st, i, skipstr))
            {

                ans = "" + skipA(st, i + skipstr.Length, skipstr);

            }
            else
            {
                ans = st[i] + skipA(st, i + 1, skipstr);
            }
            return ans;

        }
        static void Main(string[] args)
        {
            string st = "helloabchellodefhello";
            string skipstr = "hello";
            System.Console.WriteLine(skipA(st, 0, skipstr));
        }
    }
}