using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTTraversal
{
    internal class Program
    {
        public static List<int> InOrderTraversal(BST tree, List<int> array)
        {
            if(tree == null)
            {
                return array;
            }

            InOrderTraversal(tree.left, array);
            array.Add(tree.value);
            InOrderTraversal(tree.right, array);

            return array;
        }

        public static List<int> PreOrderTraversal(BST tree, List<int> array)
        {
            if(tree == null)
            {
                return array;
            }

            array.Add(tree.value);
            PreOrderTraversal(tree.left, array);
            PreOrderTraversal(tree.right, array);

            return array;
        }

        public static List<int> PostOrderTraversal(BST tree, List<int> array)
        {
            if(tree == null)
            {
                return array;
            }

            PostOrderTraversal(tree.left, array);
            PostOrderTraversal(tree.right, array);
            array.Add(tree.value);

            return array;
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
        static void Main(string[] args)
        {
        }
    }
}
