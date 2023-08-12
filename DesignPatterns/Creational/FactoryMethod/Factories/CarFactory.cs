using FactoryMethod.Contracts;
using FactoryMethod.Vehicles;

namespace FactoryMethod.Factories;

public class CarFactory : IVehicleFactory
{
    public IVehicle CreateVehicle()
    {
        return new Car();
    }
}
