using System;
using System.Collections.Generic;
namespace Algo
{

    class BinaryTreeLevelOrder
    {

        public static IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> llist = new List<IList<int>>();
            if (root == null)
            {
                return llist;
            }

            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            q.Enqueue(null);

            TreeNode p;
            IList<int> list = new List<int>();
            while (q.Count > 0)
            {

                p = q.Dequeue();



                if (p != null)
                {
                    list.Add(p.val);
                    if (p.left != null)
                        q.Enqueue(p.left);
                    if (p.right != null)
                        q.Enqueue(p.right);

                }
                else
                {
                    llist.Add(new List<int>(list));
                    list.Clear();
                    if (q.Count > 0)
                    {
                        q.Enqueue(null);
                    }
                }
            }
            return llist;

        }

        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
            var ans = LevelOrder(root);
            foreach (var list in ans)
            {
                System.Console.WriteLine(string.Join(",", list));
            }
        }
    }
}