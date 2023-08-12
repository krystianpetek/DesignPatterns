using FactoryMethod.Two.Contracts;
using FactoryMethod.Two.Factories;

namespace FactoryMethod.Two;

public static class Program
{
    public static void Main()
    {
        VehicleFactory factory = new VehicleFactory();
        IVehicle vehicle = factory.CreateVehicle(VehicleType.Car);
        vehicle.Display();

        vehicle = factory.CreateVehicle(VehicleType.OffroadCar);
        vehicle.Display();
    }
}
