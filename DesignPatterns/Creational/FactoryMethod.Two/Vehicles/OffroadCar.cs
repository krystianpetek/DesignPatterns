using System;
using FactoryMethod.Two.Contracts;

namespace FactoryMethod.Two.Vehicles;

public class OffroadCar : IVehicle
{
    public void Display()
    {
        Console.WriteLine("OffroadCar");
    }
}
