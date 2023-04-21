using System;
using System.Collections.Generic;

namespace Algo
{
    public class TreeNode2
    {
        public int val;
        public TreeNode2 left;
        public TreeNode2 right;
        public TreeNode2 next;

        public TreeNode2() { }

        public TreeNode2(int _val)
        {
            val = _val;
        }

        public TreeNode2(int _val, TreeNode2 _left, TreeNode2 _right, TreeNode2 _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }
    class PopulatingNextRightPointersinEachTreeNode2
    {
        public static TreeNode2 Connect(TreeNode2 root)
        {
            if (root == null)
            {
                return root;
            }
            Queue<TreeNode2> q = new Queue<TreeNode2>();
            q.Enqueue(root);
            q.Enqueue(null);
            while (q.Count > 0)
            {
                TreeNode2 p = q.Dequeue();

                if (p != null)
                {
                    if (p.left != null)
                    {
                        q.Enqueue(p.left);
                    }
                    if (p.right != null)
                    {
                        q.Enqueue(p.right);
                    }
                    p.next = q.Peek();
                }
                else
                {
                    if (q.Count > 0)
                    {
                        q.Enqueue(null);
                    }
                }
            }
            return root;

        }

        public static void preorder(TreeNode2 root)
        {
            if (root == null)
            {
                return;
            }
            int nextval = (root.next == null) ? 0 : root.next.val;
            System.Console.WriteLine($"{root.val} => {nextval}");
            preorder(root.left);
            preorder(root.right);
        }
        static void Main(string[] args)
        {
            TreeNode2 root = new TreeNode2(1, new TreeNode2(2), new TreeNode2(3), null);
            root.left.left = new TreeNode2(4);
            root.left.right = new TreeNode2(5);
            root.right.left = new TreeNode2(6);
            root.right.right = new TreeNode2(7);

            TreeNode2 temproot = Connect(root);
            preorder(temproot);
        }
    }
}