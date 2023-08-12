using FactoryMethod.Contracts;
using System;

namespace FactoryMethod.Vehicles;

public class OffroadCar : IVehicle
{
    public void Display()
    {
        Console.WriteLine("OffroadCar");
    }
}
