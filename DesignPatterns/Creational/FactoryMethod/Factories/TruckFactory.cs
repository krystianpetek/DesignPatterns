using FactoryMethod.Contracts;
using FactoryMethod.Vehicles;

namespace FactoryMethod.Factories;

public class TruckFactory : IVehicleFactory
{
    public IVehicle CreateVehicle()
    {
        return new Truck();
    }
}
