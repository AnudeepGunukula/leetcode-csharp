using System;
using System.Collections.Generic;
namespace Algo
{
    class DiceRecursion
    {

        public static List<string> diceret(string pr, int target)
        {
            List<string> ans = new List<string>();
            if (target == 0)
            {
                ans.Add(pr);
                return ans;
            }
            for (int i = 1; i <= 6 && i <= target; i++)
            {
                ans.AddRange(diceret(pr + i, target - i));
            }
            return ans;

        }
        public static void dice(string pr, int target)
        {
            if (target == 0)
            {
                System.Console.WriteLine(pr);
                return;
            }
            for (int i = 1; i <= 6 && i <= target; i++)
            {
                dice(pr + i, target - i);
            }

        }
        static void Main(string[] args)
        {
            //  dice("", 4);
            diceret("", 4).ForEach(Console.WriteLine);

        }
    }
}