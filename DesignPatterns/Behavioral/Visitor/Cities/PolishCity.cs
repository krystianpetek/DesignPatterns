using Visitor.Contracts;

namespace Visitor.Cities;

public class PolishCity : ICity
{
    public string City { get; init; }
    public PolishCity(string city) => City = city;
    public void Accept(IVisitor visitor) => visitor.Visit(this);
}
