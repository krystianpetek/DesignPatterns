using AbstractFactory.Two.Contracts;

namespace AbstractFactory.Two.VehicleFactory.Fiat.Cars;

public class FiatTipo : ICar
{
    public string DisplayCar()
    {
        return "Fiat Tipo";
    }
}
