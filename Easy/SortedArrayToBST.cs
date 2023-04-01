using System;

namespace Algo
{
    class SortedArrayToBST
    {

        public static TreeNode bst(int[] nums, int left, int right)
        {
            if (left > right)
            {
                return null;
            }

            int mid = (left + right) / 2;
            TreeNode root = new TreeNode(nums[mid]);
            root.left=bst(nums,left,mid-1);
            root.right=bst(nums,mid+1,right);

            return root;

        }

        public static TreeNode sortarrtobst(int[] nums)
        {
            int n = nums.Length;
            return bst(nums, 0, n-1);


        }

        public static void inorder(TreeNode root){
             if(root==null){
                return;
             }
             inorder(root.left);
             System.Console.WriteLine(root.val);
             inorder(root.right);
        }
        static void Main(string[] args)
        {

           TreeNode root= sortarrtobst(new int[] { -10, -3, 0, 5, 9 });
           inorder(root);
           

        }
    }
}