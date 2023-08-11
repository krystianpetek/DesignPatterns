using Bridge.Two.Contracts;

namespace Bridge.Two.Features.CarTypes;

public class OffroadCar : CarType
{
    public OffroadCar(IManufacturer manufacturer) : base(manufacturer) { }

    public override string ToString()
    {
        return "Off-road car: " + Manufacturer.ManufacturerName();
    }
}