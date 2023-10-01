using System;
using System.Collections.Generic;


public class BSTConstruction
{
    public class BST
    {
        public int value;
        public BST left;
        public BST right;

        public BST(int value)
        {
            this.value = value;
        }

        public BST Insert(BST tree,int value)
        {
            var currentNode = this;
            while (true)
            {
                if (value < currentNode.value)
                {
                    if (currentNode.left == null)
                    {
                        currentNode.left = new BST(value);
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.left;
                    }
                }
                else
                {
                    if (value > currentNode.value)
                    {
                        if(currentNode.right == null)
                        {
                            currentNode.right = new BST(value);
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.right;
                        }
                    }
                    
                }

            }
            return this;
        }

        public bool Contains(int value)
        {
            var currentNode = this;

            while(currentNode != null)
            {
                if(value<currentNode.value)
                {
                    currentNode = currentNode.left;
                }
                else if(value > currentNode.value)
                {
                    currentNode = currentNode.right;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}