using System;
using System.Collections.Generic;
namespace Algo
{

    class FirstUniqueCharInString
    {
        public static int firstuniquechar(string s)
        {

          int[] freq=new int[26];
          foreach(char c in s){
            freq[c-'a']++;
          }
          for(int i=0;i<s.Length;i++){
            if(freq[s[i]-'a']==1){
                return i;
            }
          }
          return -1;

        }
        static void Main(string[] args)
        {
            System.Console.WriteLine(firstuniquechar("loveleetcode"));

        }
    }
}