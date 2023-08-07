namespace Composite.Contracts;

public interface IComposite
{
    void Add(IComposite element);
    void Remove(IComposite element);
    void Execute();
}