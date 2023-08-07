using Composite.Contracts;
using System;

namespace Composite.Implementation;

public class Leaf : IComposite
{
    private readonly string _name;

    public Leaf(string name)
    {
        _name = name;
    }
    
    public void Add(IComposite element) => throw new Exception("Adding elements is not supported by leaf.");
    public void Remove(IComposite element) => throw new Exception("Removing elements is not supported by leaf.");
    public void Execute() => Console.WriteLine(_name + " rendering...");
}
