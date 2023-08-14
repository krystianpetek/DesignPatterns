using Prototype.Contracts;

namespace Prototype.Products;

public class Bread : ProductPrototype
{
    public Bread(decimal price) : base(price) { }
}
