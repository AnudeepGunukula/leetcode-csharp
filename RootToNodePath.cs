using System;
using System.Collections.Generic;

namespace Algo
{
    class RootToNodePath
    {
        public static bool RootToNode(TreeNode root, List<int> list, int node)
        {
            if (root == null)
            {
                return false;
            }
            list.Add(root.val);
            if (root.val == node)
            {
                return true;
            }
            if (RootToNode(root.left, list, node) || RootToNode(root.right, list, node))
            {
                return true; 
            }
            list.RemoveAt(list.Count - 1);
            return false;
        }

        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1, new TreeNode(2, new TreeNode(4), new TreeNode(5, new TreeNode(6), new TreeNode(7))), new TreeNode(3));
            List<int> list = new List<int>();
            RootToNode(root, list, 4);
            System.Console.WriteLine(string.Join(",", list));
        }
    }
}