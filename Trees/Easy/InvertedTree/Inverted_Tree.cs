

public class Inverted_Tree
{

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val= val;
            this.left= left;
            this.right= right;
        }
    }
    public static TreeNode InvertTree(TreeNode root)
    {
        if(root == null)
            return null;

        TreeNode invertedLeft = InvertTree(root.left);
        TreeNode invertedRight = InvertTree(root.right);

        root.right = invertedLeft;
        root.left = invertedRight;

        return root;
    }

    public static void Main(string[] args)
    {
        TreeNode root = new TreeNode();
        root.val = 4;
        root.left = new TreeNode(2);
        root.right = new TreeNode(7);

        root.left.left = new TreeNode(1);
        root.left.right = new TreeNode(3);

        root.right.left = new TreeNode(6);
        root.right.right = new TreeNode(9);


        TreeNode result = InvertTree(root);
       

    }
}
