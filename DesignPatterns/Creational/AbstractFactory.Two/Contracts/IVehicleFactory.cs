namespace AbstractFactory.Two.Contracts;

public interface IVehicleFactory
{
    public ICar CreateCar();
    public ITruck CreateTruck();
}
