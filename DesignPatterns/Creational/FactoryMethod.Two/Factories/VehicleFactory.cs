using FactoryMethod.Two.Contracts;
using FactoryMethod.Two.Vehicles;
using System;

namespace FactoryMethod.Two.Factories;

public class VehicleFactory
{
    public IVehicle CreateVehicle(VehicleType vehicleType)
    {
        return vehicleType switch
        {
            VehicleType.Car => new Car(),
            VehicleType.OffroadCar => new OffroadCar(),
            VehicleType.Truck => new Truck(),
            _ => throw new ArgumentException("Not recognized vehicle type"),
        };
    }
}
