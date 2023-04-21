using System;

namespace Algo
{
    class OddEvenLinkedList
    {
        public static ListNode OddEvenList(ListNode head)
        {
            if (head == null)
            {
                return null;
            }
            ListNode oddhead = head;
            ListNode evenhead = head.next;

            ListNode odd = head;
            ListNode even = head.next;

            while (odd.next != null && even.next != null)
            {
                odd.next = even.next;
                odd = odd.next;
                even.next = odd.next;
                even = even.next;
            }
            odd.next = evenhead;

            return oddhead;
        }
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);
            ListNode temp = OddEvenList(head);
            while (temp != null)
            {
                System.Console.WriteLine(temp.val);
                temp = temp.next;
            }
        }
    }
}