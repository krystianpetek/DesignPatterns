using AbstractFactory.Two.Contracts;
using AbstractFactory.Two.VehicleFactory.Fiat.Cars;
using AbstractFactory.Two.VehicleFactory.Fiat.Trucks;

namespace AbstractFactory.Two.VehicleFactory.Fiat.Factory;

public class FiatFactory : IVehicleFactory
{
    public ITruck CreateTruck()
    {
        return new FiatDucato();
    }
    public ICar CreateCar()
    {
        return new FiatTipo();
    }
}
