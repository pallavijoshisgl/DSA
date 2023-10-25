using System;

public class LCA_Binary_Search_Tree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val)
        {
            this.val = val;
            this.left = null;
            this.right = null;
        }


        public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if(p.val > root.val && q.val > root.val)
            {
                return LowestCommonAncestor(root.right, p, q);
            }
            else if(p.val < root.val && q.val < root.val)
            {
                return LowestCommonAncestor(root.left, p, q);
            }
            else
            {
                return root;
            }

        }

        public static void Main(string[] args)
        {
            TreeNode p = new TreeNode(2);
            TreeNode q = new TreeNode(8);
            TreeNode root = new TreeNode(6);
            root.left= new TreeNode(2);
            root.right= new TreeNode(8);

            root.left.left = new TreeNode(0);
            root.left.right = new TreeNode(4);

            root.right.left = new TreeNode(7);
            root.right.right = new TreeNode(9);

            root.left.right.left = new TreeNode(3);
            root.left.right.right= new TreeNode(5);

            TreeNode result=LowestCommonAncestor(root, p, q);
          
        }
    }
}
