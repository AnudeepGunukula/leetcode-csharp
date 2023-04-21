using System;
using System.Collections.Generic;
namespace Algo
{

    class BeautifulArray
    {



        public static int[] makeBeautiful(int[] arr)
        {
            Stack<int> st = new Stack<int>();

            foreach (int i in arr)
            {
                if (st.Count == 0 || (st.Peek() >= 0 && i >= 0) || (st.Peek() < 0 && i < 0))
                {
                    st.Push(i);
                }
                else
                {
                    st.Pop();
                }
            }

            return st.ToArray();



        }
        static void Main(string[] args)
        {
            int[] arr = { -145, -69, 56, -123, 84, 76, -49, -169, -141, -173, -79, -71, 82, -87, 162, 182, -73, -151, -95, -195, 10, 42, 24, -171, 184, 44, 54, -141, 110, 58, 186, -39, -47, -69, -87, 148, -111, 32, -189, 92, 32 };

            int[] ans = makeBeautiful(arr);
            foreach (var i in ans)
            {
                System.Console.Write(i + " ");
            }

        }
    }
}