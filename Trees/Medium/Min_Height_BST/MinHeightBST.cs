using System;
using System.Collections.Generic;


public class MinHeightBST
{

    public static BST GetMinHeightBST(List<int> array)
    {
        return CreateNode(array, 0, array.Count - 1);
    }

    public static BST CreateNode(List<int> array,int i, int j)
    {
        if(j<i)
        {
            return null;
        }

        int mid = (i + j) / 2;

        var node = new BST(array[mid]);

        node.left = CreateNode(array, i, mid - 1);
        node.right = CreateNode(array, mid + 1, j);

        return node;
    }

    public static void Main(string[] args)
    {
        List<int> inputArr = new List<int>() { 1, 2, 5, 7, 10, 13, 14, 15, 22};
        BST result = GetMinHeightBST(inputArr);

        
    }


    public class BST
    {
        public int value;
        public BST left;
        public BST right;

        public BST(int value)
        {
            this.value = value;
            left = null;
            right = null;

        }


        public void insert(int value)
        {
            if (value < this.value)
            {
                if(left == null)
                {
                    left = new BST(value);
                }
                else
                {
                    left.insert(value);
                }
            }
            else
            {
                if(right == null)
                {
                    right = new BST(value);
                }
                else
                {
                    right.insert(value);
                }
            }
        }
    }
}