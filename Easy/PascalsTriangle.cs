using System;
using System.Collections.Generic;

namespace Algo
{
    class PascalsTriangle
    {

        public static IList<IList<int>> Generate(int numRows) {
            IList<IList<int>> llist=new List<IList<int>>();
            for(int i=0;i<numRows;i++){
                IList<int> list=new List<int>();
                for(int j=0;j<=i;j++){
                     if(j==0 || j==i){
                         list.Add(1);
                     }else{
                        list.Add(llist[i-1][j-1]+llist[i-1][j]);
                     }
                }
                llist.Add(list);

            }
            return llist;
        
    }

        static void Main(string[] args)
        {
           int n=Convert.ToInt32(Console.ReadLine());

           IList<IList<int>> ans= Generate(n);
           foreach(var list in ans){
              foreach(var i in list){
                 System.Console.Write(i+" ");
              }
              System.Console.WriteLine();
           }
        }
    }
}