using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SearchBST
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
        public TreeNode SearchINBST(TreeNode root, int val)
        {
            if(root == null)
                return null;

            if (root.val == val)
            {
                return root;
            }
            else if (root.val < val)
            {
                return SearchINBST(root.right, val);
            }
            else
            {
                return SearchINBST(root.left, val);
            }

        }
        static void Main(string[] args)
        {
        }
    }
}
