using Bridge.Two.Contracts;

namespace Bridge.Two.Features.Manufacturers;

public class Ford : IManufacturer
{
    public string ManufacturerName()
    {
        return "Ford";
    }

}
