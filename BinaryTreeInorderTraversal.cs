using System;
using System.Collections.Generic;
namespace Algo
{

    // public class TreeNode{
    //     public int val;
    //     public TreeNode left;
    //     public TreeNode right;

    //     public TreeNode(int val=0,TreeNode left=null,TreeNode right=null){
    //         this.val=val;
    //         this.left=left;
    //         this.right=right;
    //     }
    // }

    class BinaryTreeInorderTraversal
    {

        public static void inorder(TreeNode root, IList<int> list)
        {
            if (root == null)
            {
                return;
            }
            inorder(root.left, list);
            list.Add(root.val);
            inorder(root.right, list);

        }

        static void Main(string[] args)
        {
            IList<int> list = new List<int>();
            TreeNode root = new TreeNode(1, null, new TreeNode(2));
            TreeNode temp = root;
            temp = temp.right;
            temp.left = new TreeNode(3);
            inorder(root, list);

            foreach (var i in list)
            {
                System.Console.WriteLine(i);
            }


        }
    }
}