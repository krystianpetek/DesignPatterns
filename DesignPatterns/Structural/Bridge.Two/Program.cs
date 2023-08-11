using System;
using Bridge.Two.Contracts;
using Bridge.Two.Features.CarTypes;
using Bridge.Two.Features.Manufacturers;

namespace Bridge.Two;

internal static class Program
{
    internal static void Main()
    {
        CarType carType = new Car(new Fiat());
        Console.WriteLine(carType);
        
        carType = new OffroadCar(new Ford());
        Console.WriteLine(carType);
    }
}
