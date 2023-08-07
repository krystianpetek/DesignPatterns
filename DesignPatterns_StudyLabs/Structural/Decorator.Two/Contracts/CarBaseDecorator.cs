namespace Decorator.Two.Contracts;

public abstract class CarBaseDecorator : ICar
{
    protected readonly ICar _samochod;
    protected CarBaseDecorator(ICar samochod)
    {
        _samochod = samochod;
    }
    public abstract double Price();
    public abstract string Description();
}
