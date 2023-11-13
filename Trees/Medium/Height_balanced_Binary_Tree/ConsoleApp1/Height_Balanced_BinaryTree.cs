using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Height_Balanced_BinaryTree
    {
        public static bool IsBalancedBinaryTree(BinaryTree tree)
        {
            return GetHeightOfBalancedbinaryTree(tree) != -1;
        }

        public static int GetHeightOfBalancedbinaryTree(BinaryTree tree)
        {
             if(tree == null)
            {
                return 0;
            }

            int leftSubTree = GetHeightOfBalancedbinaryTree(tree.left);
            int rightSubTree = GetHeightOfBalancedbinaryTree(tree.right);

            if(leftSubTree == -1 || rightSubTree == -1)
            {
                return -1;
            }

            if(Math.Abs(leftSubTree - rightSubTree) > 1)
            {
                return -1;
            }

            return Math.Max(leftSubTree, rightSubTree) + 1;
        }

        static void Main(string[] args)
        {

        }
    }

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
}
