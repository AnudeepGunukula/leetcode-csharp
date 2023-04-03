using System;
using System.Collections.Generic;

namespace Algo
{
    class IntersectionOfTwoLinkedList
    {

        public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            HashSet<ListNode> set = new HashSet<ListNode>();
            ListNode temp = headA;
            while (temp != null)
            {
                set.Add(temp);
                temp = temp.next;
            }
            temp = headB;
            while (temp != null)
            {
                if (set.Contains(temp))
                {
                    return temp;
                }
                temp = temp.next;
            }
            return null;

        }
        static void Main(string[] args)
        {
            ListNode headA = new ListNode(1);
            headA.next = new ListNode(9);
            headA.next.next = new ListNode(1);
            ListNode temp = new ListNode(2);
            headA.next.next.next = temp;
            headA.next.next.next.next = new ListNode(4);


            ListNode headB = new ListNode(3);
            headB.next = temp;



            ListNode ans = GetIntersectionNode(headA, headB);

            while (ans != null)
            {
                System.Console.WriteLine(ans.val);
                ans = ans.next;
            }


        }
    }

}