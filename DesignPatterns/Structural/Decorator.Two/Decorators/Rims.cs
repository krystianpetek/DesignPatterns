using Decorator.Two.Contracts;

namespace Decorator.Two.Decorators;

public class Rims : CarBaseDecorator
{
    private string opis = " felgi aluminiowe";
    private double koszt = 8000.0;
    public Rims(ICar samochod) : base(samochod)
    {
    }

    public override double Price()
    {
        return _samochod.Price() + koszt;
    }

    public override string Description()
    {
        return _samochod.Description() + opis;
    }
}
