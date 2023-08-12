using System;
using AbstractFactory.Two.VehicleFactory.Fiat.Factory;
using AbstractFactory.Two.VehicleFactory.Ford.Factory;

namespace AbstractFactory.Two;

public static class Program
{
    public static void Main()
    {
        VehicleSystem vehicleSystem = new VehicleSystem(new FiatFactory());
        vehicleSystem.DisplayCar();
        vehicleSystem.DisplayTruck();
        Console.WriteLine();

        vehicleSystem = new VehicleSystem(new FordFactory());
        vehicleSystem.DisplayCar();
        vehicleSystem.DisplayTruck();
    }
}
