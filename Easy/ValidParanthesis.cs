using System;
using System.Collections.Generic;

namespace Algo
{
    class ValidParanthesis
    {



        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {

                if (stack.Count != 0)
                {
                    if ((s[i] == ')' && stack.Peek() == '(') || (s[i] == '}' && stack.Peek() == '{') || (s[i] == ']' && stack.Peek() == '['))
                    {
                        stack.Pop();
                    }

                }
                else
                {
                    stack.Push(s[i]);
                }
            }

            return stack.Count == 0;


        }

        static void Main(string[] args)
        {

            System.Console.WriteLine(IsValid("({[)"));

        }
    }
}