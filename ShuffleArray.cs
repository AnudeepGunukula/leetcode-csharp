using System;
using System.Collections.Generic;

namespace Algo
{

    public class shuffle
    {
        int[] arr;
        List<int> arrc = new List<int>();
        public shuffle(int[] nums)
        {
            arr = nums;
            for (int i = 0; i < nums.Length; i++)
            {
                arrc.Add(nums[i]);
            }

        }

        public int[] Reset()
        {
            return arrc.ToArray();
        }

        public int[] Shuffle()
        {
            int x = new Random().Next(0, this.arr.Length);
            int y = new Random().Next(0, this.arr.Length);

            (arr[x], arr[y]) = (arr[y], arr[x]);

            return arr;

        }
    }
    class ShuffleArray
    {

        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3 };
            shuffle s = new shuffle(nums);

            int[] param_2 = s.Shuffle();
            int[] param_1 = s.Reset();

            System.Console.WriteLine(string.Join(",", param_2));
            System.Console.WriteLine(string.Join(",", param_1));

        }
    }
}