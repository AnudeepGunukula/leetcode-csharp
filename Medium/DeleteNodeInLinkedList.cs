using System;

namespace Algomed
{


    class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    class DeleteNodeInLinkedList
    {

        public static void DeleteNode(ListNode node)
        {

            while (node.next.next != null)
            {
                System.Console.WriteLine(node.next.val + "->" + node.val);
                node.val = node.next.val;

                node = node.next;
            }
            node.val=node.next.val;
            node.next=null;


        }
        static void Main(string[] args)
        {
            ListNode head = new ListNode(4, new ListNode(5, new ListNode(1, new ListNode(9))));
            ListNode p = head;
            DeleteNode(p.next);

            while(head!=null){
                System.Console.WriteLine(head.val);
                head=head.next;
            }


        }
    }
}