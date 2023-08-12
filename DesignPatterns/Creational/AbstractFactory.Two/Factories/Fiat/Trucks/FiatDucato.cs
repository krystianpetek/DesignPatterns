using AbstractFactory.Two.Contracts;

namespace AbstractFactory.Two.VehicleFactory.Fiat.Trucks;

public class FiatDucato : ITruck
{
    public string DisplayTruck()
    {
        return "Fiat Ducato";
    }
}
