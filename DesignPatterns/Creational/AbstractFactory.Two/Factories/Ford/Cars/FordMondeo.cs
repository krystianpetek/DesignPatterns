using AbstractFactory.Two.Contracts;

namespace AbstractFactory.Two.VehicleFactory.Ford.Cars;

public class FordMondeo : ICar
{
    public string DisplayCar()
    {
        return "Ford Mondeo";
    }
}
