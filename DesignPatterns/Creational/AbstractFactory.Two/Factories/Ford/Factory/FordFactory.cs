using AbstractFactory.Two.Contracts;
using AbstractFactory.Two.VehicleFactory.Ford.Cars;
using AbstractFactory.Two.VehicleFactory.Ford.Trucks;

namespace AbstractFactory.Two.VehicleFactory.Ford.Factory;

public class FordFactory : IVehicleFactory
{
    public ITruck CreateTruck()
    {
        return new FordTransit();
    }
    public ICar CreateCar()
    {
        return new FordMondeo();
    }
}
