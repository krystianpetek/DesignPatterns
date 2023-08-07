using Bridge.Two.Contracts;

namespace Bridge.Two.Features.CarTypes;

public class Car : CarType
{
    public Car(IManufacturer manufacturer) : base(manufacturer) { }

    public override string ToString()
    {
        return "Car: " + Manufacturer.ManufacturerName();
    }
}
