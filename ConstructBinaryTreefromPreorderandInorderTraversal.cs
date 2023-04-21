using System;
using System.Collections.Generic;
namespace Algo
{
    class ConstructBinaryTreefromPreorderandInorderTraversal
    {

        public static TreeNode helper(int[] preorder, int prestart, int preend, int instart, int inend, Dictionary<int, int> inorder_map)
        {
            if (instart > inend)
            {
                return null;
            }

            int val = preorder[prestart];

            TreeNode root = new TreeNode(val);

            int index = inorder_map[val];
            int numsleft = index - instart;
            root.left = helper(preorder, prestart + 1, prestart + numsleft, instart, index - 1, inorder_map);
            root.right = helper(preorder, prestart + numsleft + 1, preend, index + 1, inend, inorder_map);

            return root;


        }
        public static TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < inorder.Length; i++)
            {
                dict[inorder[i]] = i;
            }
            return helper(preorder, 0, preorder.Length - 1, 0, inorder.Length - 1, dict);
        }

        public static void Inorder(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            Inorder(root.left);
            System.Console.WriteLine(root.val);
            Inorder(root.right);
        }
        static void Main(string[] args)
        {
            int[] preorder = new int[] { 3, 9, 20, 15, 7 };
            int[] inorder = new int[] { 9, 3, 15, 20, 7 };


            TreeNode root = BuildTree(preorder, inorder);
            Inorder(root);
        }
    }
}