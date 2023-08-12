using FactoryMethod.Contracts;
using FactoryMethod.Factories;
using System;

namespace FactoryMethod;

public static class Program
{
    public static void Main()
    {
        IVehicleFactory factory = new CarFactory();
        IVehicle vehicle = factory.CreateVehicle();
        vehicle.Display();

        factory = new TruckFactory();
        vehicle = factory.CreateVehicle();
        vehicle.Display();
    }
}
