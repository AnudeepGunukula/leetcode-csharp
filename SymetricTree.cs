using System;


namespace Algo
{

    class SymetricTree
    {

        public static bool issym(TreeNode left, TreeNode right)
        {
            if (left == null || right == null)
            {
                return left == right;
            }
            if (left.val != right.val)
            {
                return false;
            }

            return issym(left.left, right.right) && issym(left.right, right.left);

        }
        public static bool IsSymmetric(TreeNode root)
        {
            return issym(root.left, root.right);

        }
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2, new TreeNode(3), new TreeNode(4));
            root.right = new TreeNode(2, new TreeNode(4), new TreeNode(3));

            System.Console.WriteLine(IsSymmetric(root));


        }
    }
}