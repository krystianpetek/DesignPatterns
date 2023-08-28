using Visitor.Contracts;

namespace Visitor.Cities;

public class UsaCity : ICity
{
    public string City { get; init; }
    public UsaCity(string city) => City = city;
    public void Accept(IVisitor visitor) => visitor.Visit(this);
}
