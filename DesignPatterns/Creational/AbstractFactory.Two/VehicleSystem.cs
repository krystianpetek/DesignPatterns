using System;
using AbstractFactory.Two.Contracts;

namespace AbstractFactory.Two;

public class VehicleSystem
{
    private readonly IVehicleFactory _carFactory;
    private readonly ICar _car;
    private readonly ITruck _truck;

    public VehicleSystem(IVehicleFactory carFactory)
    {
        _carFactory = carFactory;
        _car = _carFactory.CreateCar();
        _truck = _carFactory.CreateTruck();
    }

    public void DisplayCar() => Console.WriteLine($"{_carFactory.GetType().Name}: {_car.DisplayCar()}");
    public void DisplayTruck() => Console.WriteLine($"{_carFactory.GetType().Name}: {_truck.DisplayTruck()}");
}
