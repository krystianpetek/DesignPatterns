using System;
using FactoryMethod.Two.Contracts;

namespace FactoryMethod.Two.Vehicles;

public class Truck : IVehicle
{
    public void Display()
    {
        Console.WriteLine("Truck");
    }
}
