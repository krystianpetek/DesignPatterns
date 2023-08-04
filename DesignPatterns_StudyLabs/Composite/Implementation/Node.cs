using Composite.Contracts;
using System;
using System.Collections.Generic;

namespace Composite.Implementation;

public class Node : IComposite
{
    private readonly List<IComposite> _nodes;
    private readonly string _name;

    public Node(string name)
    {
        _name = name;
        _nodes = new List<IComposite>();
    }

    public void Add(IComposite element) => _nodes.Add(element);
    public void Remove(IComposite element) => _nodes.Remove(element);
    
    public void Execute()
    {
        Console.WriteLine($"{_name} render started.");

        foreach (var item in _nodes)
            item.Execute();

        Console.WriteLine($"{_name} render ended.");
    }
}
