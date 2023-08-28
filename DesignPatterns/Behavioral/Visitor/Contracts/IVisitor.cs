using Visitor.Cities;

namespace Visitor.Contracts;

public interface IVisitor
{
    void Visit(PolishCity polishCity);
    void Visit(NetherlandCity netherlandCity);
    void Visit(UsaCity usaCity);
    void PrintInfo();
}
