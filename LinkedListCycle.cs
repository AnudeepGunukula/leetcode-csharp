using System;
using System.Collections.Generic;
namespace Algo
{

    class LinkedListCycle
    {

        public static bool HasCycle(ListNode head)
        {
            HashSet<ListNode> set = new HashSet<ListNode>();
            ListNode p = head;
            while (p != null)
            {
                if (set.Contains(p))
                {
                    return true;
                }
                else
                {
                    set.Add(p);
                }
                p = p.next;

            }
            return false;



        }
        static void Main(string[] args)
        {
            ListNode head = new ListNode(3);
            ListNode p = new ListNode(2);
            head.next = p;
            head.next.next = new ListNode(0);
            head.next.next = new ListNode(-4);
            head.next.next.next = p;

            System.Console.WriteLine(HasCycle(head));


        }
    }
}