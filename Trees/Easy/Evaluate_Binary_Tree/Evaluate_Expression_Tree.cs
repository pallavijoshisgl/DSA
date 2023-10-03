using System;
using System.Collections.Generic;


public class Evaluate_Expression_Tree
{
    public class BinaryTree
    {
        public int value;
        public BinaryTree left;
        public BinaryTree right;

        public BinaryTree(int value)
        {
            this.value = value;
            left = null;
            right = null;
        }
    }

    public static int EvaluateExpressionTree(BinaryTree tree)
    {
        if(tree.value >= 0)
        {
            return tree.value;
          
        }

        int leftValue = EvaluateExpressionTree(tree.left);
        int rightValue = EvaluateExpressionTree(tree.right);

        if(tree.value == -1)
        {
            return leftValue + rightValue;
        }
        if(tree.value == -2)
        {
            return leftValue - rightValue;

        }
        if(tree.value == -3)
        {
            return Convert.ToInt32(leftValue / rightValue);
        }

        return leftValue * rightValue;

    }

    public static void Main(string[] args)
    {
        BinaryTree bt = new BinaryTree(-1);
        bt.left = new BinaryTree(-2);
        bt.right = new BinaryTree(-3);

        bt.left.left = new BinaryTree(-4);
        bt.left.right = new BinaryTree(2);

        bt.left.left.left = new BinaryTree(2);
        bt.left.left.right = new BinaryTree(3);

        bt.right.left = new BinaryTree(8);
        bt.right.right = new BinaryTree(3);

        Console.WriteLine(EvaluateExpressionTree(bt));
    }

   
}