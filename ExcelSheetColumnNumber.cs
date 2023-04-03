using System;

namespace Algo
{

    class ExcelSheetColumnNumber

    {
        public static int TitleToNumber(string columnTitle)
        {
            char[] colarr = columnTitle.ToCharArray();
            Array.Reverse(colarr);
            string st = new String(colarr);

            int pow = 1;
            int ans = 0;
            foreach (char i in st)
            {
                int val = i - 'A'+1;
                ans += (val * pow);
                pow *= 26;
            }
           return ans;

        }
        static void Main(string[] args)
        {

            System.Console.WriteLine(TitleToNumber("ZY"));

        }
    }
}