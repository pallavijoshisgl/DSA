using System;


public class MergeBinaryTree
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

    public static BinaryTree MergeBinaryTrees(BinaryTree Tree1,BinaryTree Tree2)
    {
        Tree1.value += Tree2.value;

        if(Tree1.left != null && Tree2.left!=null)
        {
            MergeBinaryTrees(Tree1.left, Tree2.left);
        }

        if(Tree1.right != null && Tree2.right!=null)
        {
            MergeBinaryTrees(Tree1.right, Tree2.right);
        }

        if(Tree1.left == null && Tree2.left != null)
        {
            Tree1.left = Tree2.left;
        }

        if(Tree1.right == null && Tree2.right !=null)
        {
            Tree1.right = Tree2.right;
        }

        return Tree1;
    }

    public static void Main(string[] args)
    {
        BinaryTree tree1 = new BinaryTree(7);
        tree1.left = new BinaryTree(1);
        tree1.right = new BinaryTree(2);
        BinaryTree tree2 = new BinaryTree(3);
        tree2.left = new BinaryTree(4);
        tree2.right = new BinaryTree(5);

        BinaryTree result=MergeBinaryTrees(tree1, tree2);
        Console.WriteLine(result);

    }
    
}