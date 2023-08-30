using System;
using System.Collections.Generic;


public class SplitBinaryTree
{
    public class BinaryTree
    {
        public int value;
        public BinaryTree left;
        public BinaryTree right;

        public BinaryTree(int value)
        {
            this.value = value;
        }


    }

    public static int SplitsBinaryTree(BinaryTree tree)
    {
        var lstTreeSum = new List<int>();
        var numTreeSum = GetTreeSum(lstTreeSum, tree);
        if(numTreeSum % 2 !=0)
        {
            return 0;
        }
        foreach (var sum in lstTreeSum)
        {
            if(sum == numTreeSum/2)
            {
                return sum;
            }
        }
        return 0;
    }

    public static int GetTreeSum(List<int> lstTreeSum,BinaryTree tree)
    {
        if(tree==null)
        {
            return 0;
        }

        var numLeftSum=GetTreeSum(lstTreeSum, tree.left);
        var numRightSum= GetTreeSum(lstTreeSum, tree.right);
        var numTotal = tree.value + numLeftSum + numRightSum;
        lstTreeSum.Add(numTotal);
        return numTotal;
    }

    public static void Main(string[] args)
    {

    }
}

