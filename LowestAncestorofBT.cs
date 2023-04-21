using System;

namespace Algo
{
    class LowestAncestorofBT
    {
        public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == p || root == q || root == null)
            {
                return root;
            }


            TreeNode left = LowestCommonAncestor(root.left, p, q);
            TreeNode right = LowestCommonAncestor(root.right, p, q);

            if (left == null)
            {
                return right;
            }
            if (right == null)
            {
                return left;
            }
            return root;
        }
        static void Main(string[] args)
        {
            TreeNode p = new TreeNode(6);
            TreeNode q = new TreeNode(8);
            TreeNode root = new TreeNode(3, new TreeNode(5, p, new TreeNode(2, new TreeNode(7), new TreeNode(4))), new TreeNode(1, new TreeNode(0), q));
            TreeNode ans = LowestCommonAncestor(root, p, q);
            System.Console.WriteLine(ans.val);
        }
    }
}