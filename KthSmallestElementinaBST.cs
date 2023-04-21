using System;
using System.Collections.Generic;
namespace Algo
{
    class KthSmallestElementinaBST
    {
        public static void inorder(TreeNode root, List<int> list)
        {
            if (root == null)
            {
                return;
            }
            inorder(root.left, list);
            list.Add(root.val);
            inorder(root.right, list);
        }
        public static int KthSmallest(TreeNode root, int k)
        {
            List<int> list = new List<int>();
            inorder(root, list);
            return list[k - 1];

        }
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(3, new TreeNode(1), new TreeNode(4));
            root.left.right = new TreeNode(2);
            System.Console.WriteLine(KthSmallest(root, 1));
        }
    }
}