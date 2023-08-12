using FactoryMethod.Contracts;
using FactoryMethod.Vehicles;

namespace FactoryMethod.Factories;

public class OffroadCarFactory : IVehicleFactory
{
    public IVehicle CreateVehicle()
    {
        return new OffroadCar();
    }
}
