using System;

namespace Algo
{

    class ValidPalindrome
    {

        public static bool IsPalindrome(string s)
        {
            string st = "";
            foreach (char c in s)
            {
                if (Char.IsLetterOrDigit(c))
                {
                    st += Char.ToLower(c);
                }
            }
            int n = st.Length;
            for (int i = 0; i < n; i++)
            {
                if (st[i] != st[n - i - 1])
                {
                    return false;
                }
            }
            return true;

        }
        static void Main(string[] args)
        {
            System.Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));
        }
    }
}