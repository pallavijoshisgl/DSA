using System;
using System.Collections.Generic;

public class BranchSums
{
    public class BinaryTree
    {
        public int value;
        public BinaryTree left;
        public BinaryTree right;

        public BinaryTree(int value)
        {
            this.value = value;
            this.left = null;
            this.right = null;
        }

        public static List<int> BranchSums(BinaryTree root)
        {
            var x=new List<int>();
            InOrder(root, 0, x);
            return x;
        }

        public static void InOrder(BinaryTree node,int sum,List<int> output)
        {
            if(node == null)
            {
                return;
            }
            sum = sum + node.value;
            if(node.left == null && node.right == null)
            {
                output.Add(sum);
                return;
            }

            InOrder(node.left, sum, output);
            InOrder(node.right, sum, output);
        }


        public static void Main(string[] args)
        {

        }


    }















}