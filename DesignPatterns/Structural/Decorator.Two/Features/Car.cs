using Decorator.Two.Contracts;

namespace Decorator.Two.Features;

public class Car : ICar
{
    private readonly double _price;
    private readonly string _description;

    public Car()
    {
        _price = 120_000.0;
        _description = "Standard version of interior.";
    }

    public double Price() => _price;

    public string Description() => _description;
}
