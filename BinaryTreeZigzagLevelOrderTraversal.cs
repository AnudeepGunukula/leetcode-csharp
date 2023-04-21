using System;
using System.Collections.Generic;

namespace Algo
{

    class BinaryTreeZigzagLevelOrderTraversal
    {

        public static IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            bool odd = true;

            IList<IList<int>> llist = new List<IList<int>>();


            while (q.Count > 0)
            {
                int qsize = q.Count;
                int[] list = new int[qsize];
                for (int i = 0; i < qsize; i++)
                {
                    TreeNode p = q.Dequeue();
                    if (odd)
                    {
                        list[i] = p.val;
                    }
                    else
                    {
                        list[qsize - i - 1] = p.val;
                    }
                    if (p.left != null)
                    {
                        q.Enqueue(p.left);
                    }
                    if (p.right != null)
                    {
                        q.Enqueue(p.right);
                    }
                }
                odd = !odd;
                llist.Add(new List<int>(list));


            }
            return llist;
        }

        public static IList<IList<int>> ZigzagLevelOrderNaiveApproach(TreeNode root)
        {


            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            q.Enqueue(null);

            IList<IList<int>> llist = new List<IList<int>>();
            List<int> list = new List<int>();
            bool odd = true;

            while (q.Count > 0)
            {
                TreeNode p = q.Dequeue();

                if (p != null)
                {
                    list.Add(p.val);
                    if (p.left != null)
                    {
                        q.Enqueue(p.left);
                    }
                    if (p.right != null)
                    {
                        q.Enqueue(p.right);
                    }

                }
                else
                {
                    if (q.Count > 0)
                    {
                        q.Enqueue(null);

                    }
                    if (odd)
                    {
                        llist.Add(new List<int>(list));
                    }
                    else
                    {
                        list.Reverse();
                        llist.Add(new List<int>(list));
                    }
                    odd = !odd;
                    list = new List<int>();
                }
            }

            return llist;
        }
        static void Main(string[] args)
        {

            TreeNode root = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
            var llist = ZigzagLevelOrder(root);
            foreach (var list in llist)
            {
                System.Console.WriteLine(string.Join(",", list));
            }

        }
    }
}