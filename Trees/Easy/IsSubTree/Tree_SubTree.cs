using System;

public class Tree_SubTree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val=0, TreeNode left=null,TreeNode right=null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public static bool IsSubTree(TreeNode root, TreeNode subRoot)
    {
        if(subRoot == null)
        {
            return true;
        }
        if(root == null)
        {
            return false;
        }

        if (IsSameTree(root, subRoot)) return true;

        return(IsSubTree(root.left, subRoot) || IsSubTree(root.right, subRoot));
    }

    public static bool IsSameTree(TreeNode root,TreeNode subRoot)
    {
        if (root == null && subRoot == null)
            return true;

        if (root!=null && subRoot!=null && root.val == subRoot.val && IsSameTree(root.left,subRoot.left) && IsSameTree(root.right,subRoot.right))
        {
            return true;
        }

        return false;
    }

    public static void Main(string[] args)
    {

    }
}
