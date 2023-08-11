using Composite.Implementation;

namespace Composite;

public static class Program
{
    public static void Main()
    {
        Node root = new Node("Root");
        root.Add(new Leaf("Leaf 1.1"));

        Node node2 = new Node("Node 2");
        node2.Add(new Leaf("Leaf 2.1"));
        node2.Add(new Leaf("Leaf 2.2"));
        node2.Add(new Leaf("Leaf 2.3"));
        root.Add(node2);
        
        Node node3 = new Node("Node 3");
        node3.Add(new Leaf("Leaf 3.1"));
        node3.Add(new Leaf("Leaf 3.2"));
        Node node3_3 = new Node("Node 3.3");
        node3_3.Add(new Leaf("Leaf 3.3.1"));
        node3.Add(node3_3);        
        
        root.Add(node3);
        root.Execute();
    }
}