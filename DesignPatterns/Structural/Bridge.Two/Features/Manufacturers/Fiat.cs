using Bridge.Two.Contracts;

namespace Bridge.Two.Features.Manufacturers;

public class Fiat : IManufacturer
{
    public string ManufacturerName()
    {
        return "Fiat";
    }
}
