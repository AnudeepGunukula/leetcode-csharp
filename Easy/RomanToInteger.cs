using System;
using System.Collections.Generic;
namespace Algo
{

    class RomanToInteger
    {

        public static int romtoint(string s)
        {

            Dictionary<char, int> dict = new Dictionary<char, int>(){
            {'I',1},{'V',5},{'X',10},{'L',50},{'C',100},{'D',500},{'M',1000}
        };
            int ans = 0;

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (dict[s[i]] >= dict[s[i + 1]])
                {
                    ans += dict[s[i]];
                }
                else
                {
                    ans -= dict[s[i]];
                }
            }
            ans += dict[s[s.Length - 1]];
            return ans;

        }
        static void Main(string[] args)
        {
            romtoint("MCMXCIV");
        }
    }
}