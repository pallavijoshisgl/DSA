
public class Validate_BST
{
    public static bool ValidateBST(BST tree)
    {
        int minValue = Int32.MinValue;
        int maxValue = Int32.MaxValue;
       
        return Helper(tree, minValue, maxValue);
    }

    public static bool Helper(BST tree, int minValue,int maxValue)
    {
        if (tree == null)
        {
            return true;
        }
        if (tree.value < minValue || tree.value >= maxValue)
        {
            return false;
        }

        bool IsValidLeft = Helper(tree.left, minValue, tree.value);
        bool IsValidRight = Helper(tree.right, tree.value, maxValue);

        return IsValidLeft && IsValidRight;
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
        BST root = new BST(4);
        root.left = new BST(2);
        root.right = new BST(5);


        root.left.left = new BST(1);
        root.left.right = new BST(3);


        if(ValidateBST(root))
        {
            Console.WriteLine("Is BST");

        }
        else
        {
            Console.WriteLine("Not a BST");
        }

    }

}