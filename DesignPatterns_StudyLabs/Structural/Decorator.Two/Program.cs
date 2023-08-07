using System;
using Decorator.Two.Contracts;
using Decorator.Two.Decorators;
using Decorator.Two.Features;

namespace Decorator.Two;

public static class Program
{
    public static void Main()
    {
        ICar car = new Car();
        car = new Interior(car);
        car = new Rims(car);
        Console.WriteLine(car.Description());
        Console.WriteLine(car.Price());
    }
}
