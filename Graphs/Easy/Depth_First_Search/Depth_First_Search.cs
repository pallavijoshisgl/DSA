


public class Node
{
    public string name;
    public List<Node> children;

    public Node(string name)
    {
        this.name = name;
    }

    public Node AddChild(string name)
    {
        Node node = new Node(name);
        children.Add(node);
        return this;
    }

    public  List<string> DepthFirstSearch(List<string> array)
    {
        array.Add(name);
        foreach(Node child in children)
        {
            child.DepthFirstSearch(array);
        }
        return array;
    }

    public static void Main(string[] args)
    {
        Node node = new Node("A");
        
    }
}