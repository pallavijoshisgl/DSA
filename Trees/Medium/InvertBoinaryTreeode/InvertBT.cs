using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertBoinaryTreeode
{
    internal class InvertBT
    {
        public static void InvertBinaryTree(BinaryTree tree)
        {
            if(tree == null)
            {
                return;
            }

            var temp = tree.left;
            tree.left = tree.right;
            tree.right = temp;

            InvertBinaryTree(tree.left);
            InvertBinaryTree(tree.right);
        }

        public class BinaryTree
        {
            public int value;
            public BinaryTree left;
            public BinaryTree right;

            public BinaryTree(int val)
            {
                this.value = val;
            }

        }
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree(19);
            tree.left = new BinaryTree(1);
            tree.right = new BinaryTree(2);
            tree.left.left = new BinaryTree(23);
            tree.left.right = new BinaryTree(21);
            tree.right.left = new BinaryTree(22);
            tree.right.right = new BinaryTree(29);

            InvertBinaryTree(tree);
        }
    }
}
