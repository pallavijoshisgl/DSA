using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidateBSTCodePractice
{
    internal class ValidateBST
    {
        public static bool ValidateBinarySearchTree(BST Tree)
        {
            int minValue = Int32.MinValue;
            int maxValue = Int32.MaxValue;

            return IsValidBST(Tree, minValue, maxValue);
        }

        public static bool IsValidBST(BST tree,int minValue,int maxValue)
        {
            if(tree == null)
            {
                return true;
            }
            if(tree.value< minValue || tree.value >=maxValue)
            {
                return false;
            }
            bool IsValidLeftSubTree = IsValidBST(tree.left, minValue, tree.value);
            bool IsValidRightSubTree = IsValidBST(tree.right, tree.value, maxValue);

            return IsValidLeftSubTree && IsValidRightSubTree;
        }
        static void Main(string[] args)
        {
            BST Tree = new BST(10);
            Tree.left = new BST(5);
            Tree.right = new BST(15);

            Tree.left.left = new BST(2);
            Tree.left.right = new BST(5);

            Tree.left.left.left = new BST(1);
            Tree.right.left = new BST(13);
            Tree.right.right  = new BST(22);

            Tree.right.left.right = new BST(14);

            Console.WriteLine(ValidateBinarySearchTree(Tree));
            Console.ReadKey();
        }
    }

    public class BST
    {
        public int value;
        public BST left;
        public BST right;

        public BST(int val)
        {
            this.value = val;

        }
    }
}
