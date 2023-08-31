using System;

public class FindClosestValueBST
{
    public static int FindClosestValueInBST(BST tree, int target)
    {
        var currentNode = tree;
        var closestValue = 0;
        int currentDifference = 0;
        int MinDifference = int.MaxValue;
        while(currentNode!=null)
        {
            currentDifference=Math.Abs(currentNode.value - target);
            if(currentDifference<MinDifference)
            {
                MinDifference = currentDifference;
                closestValue = currentNode.value;
            }
            if(currentNode.value > target)
            {
                currentNode = currentNode.left;
            }
            else
            {
                currentNode = currentNode.right;
            }
        }
        return closestValue;
    }
    
   





    public class BST
    {
        public int value;
        public BST left;
        public BST right;

        public BST(int value)
        {
            this.value = value;
        }
    }


    public static void Main(string[] args)
    {

    }
}
