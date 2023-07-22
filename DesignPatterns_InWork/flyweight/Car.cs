namespace flyweight_cars;

public class Car
{
    private readonly SharedCarInfo _sharedCarInfo;
    public string _owner;
    private readonly string _plate;
    private readonly string _vinNumber;

    public Car(string make, string model, string color, string owner, string plate, string vin)
    {
        string nameTemplate = GetNameTemplate(make, model, color);
        _sharedCarInfo = SharedCarFactory.GetCar(nameTemplate);
        this._owner = owner;
        this._plate = plate;
        this._vinNumber = vin;
    }

    public string Make => _sharedCarInfo.Make;
    private static string GetNameTemplate(string make, string model, string color) => $"{make}_{model}_{color}";
    public override string ToString() => $"{_owner}'s car is a {_sharedCarInfo.Make} {_sharedCarInfo.Model} ( {_sharedCarInfo.Color} ) with license plate {_plate} and vehicle identifier number ({_vinNumber})";
}
