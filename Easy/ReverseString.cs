using System;

namespace Algo
{
    class ReverseString
    {

        public static void revstr(char[] s)
        {
            int n=s.Length;
            for(int i=0;i<s.Length/2;i++){
                (s[i],s[n-i-1])=(s[n-i-1],s[i]);
            }

        }
        static void Main(string[] args)
        {
            char[] s=new char[]{'H','E','L','L','O'};
             
            revstr(s);
            foreach(char c in s){
                System.Console.WriteLine(c);
            }

        }
    }
}