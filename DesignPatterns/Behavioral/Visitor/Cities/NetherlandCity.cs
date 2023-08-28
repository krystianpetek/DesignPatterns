using Visitor.Contracts;

namespace Visitor.Cities;

public class NetherlandCity : ICity
{
    public string City { get; init; }
    public NetherlandCity(string city) => City = city;
    public void Accept(IVisitor visitor) => visitor.Visit(this);
}
