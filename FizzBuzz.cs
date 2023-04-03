using System;
using System.Collections.Generic;
namespace Algo
{

    class FizzBuzz
    {
        public static IList<string> fizbuz(int n)
        {
            IList<string> list = new List<string>();

            for (int i = 1; i <= n; i++)
            {

                if (i % 5 == 0 && i % 3 == 0)
                {
                    list.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    list.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    list.Add("Buzz");
                }
                else
                {
                    list.Add(i.ToString());
                }

            }

            return list;

        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            IList<string> ans = fizbuz(n);
            foreach (var str in ans)
            {
                System.Console.WriteLine(str);
            }

        }
    }
}