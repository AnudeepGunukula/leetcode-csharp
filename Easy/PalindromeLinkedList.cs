using System;
using System.Collections.Generic;
namespace Algo
{

    class PalindromeLinkedList
    {

        public static bool IsPalindrome(ListNode head)
        {
            Stack<int> stack = new Stack<int>();
            ListNode p = head;
            while (p != null)
            {
                stack.Push(p.val);
                p = p.next;
            }
            p = head;
            while (p != null)
            {
                if (p.val != stack.Pop())
                {
                    return false;
                }

                p = p.next;
            }
            return true;

        }
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(2);
            head.next.next.next = new ListNode(1);
            System.Console.WriteLine(IsPalindrome(head));

        }
    }
}