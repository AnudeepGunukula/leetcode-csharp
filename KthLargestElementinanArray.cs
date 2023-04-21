using System;
using System.Collections.Generic;
namespace Algo
{
    class KthLargestElementinanArray
    {

        public static int FindKthLargest(int[] nums, int k)
        {
            // best solution O(n) worstcase
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();

            foreach (int i in nums)
            {
                pq.Enqueue(i, i);
                if (pq.Count > k)
                {
                    pq.Dequeue();
                }
            }

            return pq.Peek();

        }
        public static int FindKthLargest2(int[] nums, int k)
        {
            //O(nlogn) worstcase
            Array.Sort(nums);
            return nums[nums.Length - k];
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine(FindKthLargest(new int[] { 3, 2, 1, 5, 6, 4 }, 2));

        }
    }
}