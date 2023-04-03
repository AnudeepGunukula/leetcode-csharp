using System;

namespace Algo
{

    class MergeTwoSortedLists
    {
        public static ListNode mergetwolists(ListNode list1,ListNode list2)
        {
            ListNode root=new ListNode(0);
            ListNode p=root;
            while(list1!=null && list2!=null){
                 if(list1.val<=list2.val){
                    p.next=list1;
                    list1=list1.next;
                 }
                 else{
                    p.next=list2;
                    list2=list2.next;
                 }
                 p=p.next;
            }
            if(list1==null){
                p.next=list2;
            }
            else{
                p.next=list1;
            }
            return root.next;

        }
        static void Main(string[] args)
        {
            ListNode list1 = new ListNode(1);
            list1.next = new ListNode(2);
            list1.next.next = new ListNode(4);

            ListNode list2 = new ListNode(1);
            list2.next = new ListNode(3);
            list2.next.next = new ListNode(4);

            ListNode root=mergetwolists(list1,list2);
            while(root!=null){
                System.Console.WriteLine(root.val);
                root=root.next;
            }


        }
    }

}