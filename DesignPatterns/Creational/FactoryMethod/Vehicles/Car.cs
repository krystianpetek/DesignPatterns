using FactoryMethod.Contracts;
using System;

namespace FactoryMethod.Vehicles;

public class Car : IVehicle
{
    public void Display()
    {
        Console.WriteLine("Car");
    }
}
