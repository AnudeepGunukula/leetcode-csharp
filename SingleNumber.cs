using System;
using System.Collections.Generic;
namespace Algo
{
    class SingleNumber
    {

        public static int singlenum(int[] nums)
        {

            Dictionary<int,int> dict=new Dictionary<int, int>();
            for(int i=0;i<nums.Length;i++){
                if(dict.ContainsKey(nums[i])){
                   dict[nums[i]]++;
                }else{
                   dict[nums[i]]=1;
                }
            }
            foreach(var pair in dict){
                if(pair.Value==1){
                    return pair.Key;
                }
            }

            return 0;

        }

        static void Main(string[] args)
        {
            int[] nums={4,1,2,1,2};
            System.Console.WriteLine(singlenum(nums));

        }
    }
}