using System;

namespace Prototype.Contracts;

public abstract class ProductPrototype
{
    public decimal Price { get; set; }
    protected ProductPrototype(decimal price) => Price = price;
    public ProductPrototype Clone() => (ProductPrototype)MemberwiseClone();
    public void GetProductInfo() => Console.WriteLine($"{GetType().Name}: {Price:F2}zł");
}
