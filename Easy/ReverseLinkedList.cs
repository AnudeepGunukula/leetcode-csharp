using System;

namespace Algo
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    class ReverseLinkedList
    {

        public static ListNode revlist(ListNode head)
        {
            ListNode p = head;
            ListNode q = null;
            ListNode r = null;

            while (p != null)
            {
                r = p.next;
                p.next = q;
                q = p;
                p = r;
            }

            return q;
        }
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            ListNode p = head;
            p.next = new ListNode(2);
            p = p.next;
            p.next = new ListNode(3);
            p = p.next;
            p.next = new ListNode(4);
            p = p.next;
            p.next = new ListNode(5);

            p = revlist(head);
            while (p != null)
            {
                Console.WriteLine(p.val);
                p = p.next;
            }





        }
    }
}