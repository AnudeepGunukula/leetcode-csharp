using System;

namespace Algo
{

    class SkipACharacterUsingRecursion
    {


        public static string skipA(string st, int i)
        {
            string ans = "";

            if (i == st.Length)
            {
                return ans;
            }
            if (st[i] == 'a')
            {
                ans = "" + skipA(st, i + 1);


            }
            else
            {
                ans = st[i] + skipA(st, i + 1);
            }
            return ans;

        }
        static void Main(string[] args)
        {
            string st = "bacapplecdahapples";
            System.Console.WriteLine(skipA(st, 0));
        }
    }
}