using System;


public class SymmetricalTree
{
    public class BinaryTree
    {
        public int value;
        public BinaryTree left = null;
        public BinaryTree right = null;

        public BinaryTree(int value)
        {
            this.value = value;
        }


    }

    public static bool Symmetrical_Tree(BinaryTree tree)
    {
        if (tree == null)
        {
            return false;
        }
        return IsSymmetrical(tree.left, tree.right);

    }

    public static bool IsSymmetrical(BinaryTree leftTree,BinaryTree rightTree)
    {
        if(leftTree != null && rightTree !=null)
        {
            if(leftTree.value == rightTree.value)
            {
                return IsSymmetrical(leftTree.left, rightTree.right) && IsSymmetrical(leftTree.right , rightTree.left)? true : false;
            }
        }
        else if(leftTree == null && rightTree == null)
        {
            return true;
        }
        return false;

    }

    public static void Main(string[] args)
    {
        
    }
}