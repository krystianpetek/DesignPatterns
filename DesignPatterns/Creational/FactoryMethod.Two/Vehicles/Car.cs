using System;
using FactoryMethod.Two.Contracts;

namespace FactoryMethod.Two.Vehicles;

public class Car : IVehicle
{
    public void Display()
    {
        Console.WriteLine("Car");
    }
}
