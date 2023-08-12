using AbstractFactory.Two.Contracts;

namespace AbstractFactory.Two.VehicleFactory.Ford.Trucks;

public class FordTransit : ITruck
{
    public string DisplayTruck()
    {
        return "Ford Transit";
    }
}
