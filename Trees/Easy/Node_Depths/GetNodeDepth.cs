using System;
using System.Collections.Generic;


public class GetNodeDepth
{
    public static int NodeDepths(BinaryTree root,int depth=0)
    {
        return root != null ? depth + NodeDepths(root.left, depth + 1) + NodeDepths(root.right, depth + 1) : 0;
    }

    public class BinaryTree
    {
        public int value;
        public BinaryTree right;
        public BinaryTree left;


    }

    public static void Main(string[] args)
    {

    }
}