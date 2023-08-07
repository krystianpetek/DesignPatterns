namespace Bridge.Two.Contracts;

public abstract class CarType
{
    protected readonly IManufacturer Manufacturer;

    protected CarType(IManufacturer manufacturer)
    {
        Manufacturer = manufacturer;
    }
}
