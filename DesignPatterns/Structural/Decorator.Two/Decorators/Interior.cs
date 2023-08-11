using Decorator.Two.Contracts;

namespace Decorator.Two.Decorators;

public class Interior : CarBaseDecorator
{
    private string opis = " skórzana tapicerka";
    private double koszt = 10000.0;
    public Interior(ICar samochod) : base(samochod)
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
