using FactoryMethod.Contracts;
using System;

namespace FactoryMethod.Vehicles;

public class Truck : IVehicle
{
    public void Display()
    {
        Console.WriteLine("Truck");
    }
}
