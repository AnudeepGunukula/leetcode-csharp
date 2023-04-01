using System;
using System.Collections.Generic;
namespace Algo
{

    class PlusOne
    {


        public static int[] plus1(int[] digits)
        {

            int n = digits.Length;
            int carry = 1;
            int i = 0;

            while (n - i - 1 >= 0 && carry != 0)
            {

                if (digits[n - i - 1] + carry == 10)
                {
                    digits[n - i - 1] = 0;
                    carry = 1;
                }
                else
                {
                    digits[n - i - 1] += 1;
                    carry = 0;
                }

                i++;
            }
            if (carry == 1)
            {
                int[] ans = new int[n + 1];
                ans[0] = 1;
                for (int x = 1; x < ans.Length; x++)
                {
                    ans[x] = digits[x-1];
                }
                return ans;
            }

            return digits;

        }
        static void Main(string[] args)
        {
            int[] arr = plus1(new int[] { 9, 9, 9 });
            foreach (int i in arr)
            {
                System.Console.Write(i + " ");
            }

        }
    }
}