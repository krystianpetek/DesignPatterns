namespace Visitor.Contracts;

public interface ICity
{
    void Accept(IVisitor visitor);
}
