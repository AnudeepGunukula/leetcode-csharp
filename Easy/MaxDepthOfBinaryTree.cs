using System;
using System.Collections.Generic;
namespace Algo
{


    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class MaxDepthOfBinaryTree
    {


        public static int maxdepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return 1 + Math.Max(maxdepth(root.left), maxdepth(root.right));
        }
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(3, new TreeNode(9), new TreeNode(20));
            TreeNode temp = root;

            temp = temp.right;
            temp.left = new TreeNode(15);
            temp.right = new TreeNode(7);

            System.Console.WriteLine(maxdepth(root));




        }
    }
}