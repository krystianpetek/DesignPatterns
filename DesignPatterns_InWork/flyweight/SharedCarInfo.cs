namespace flyweight;

class SharedCarInfo
{
    private readonly string _make;
    private readonly string _model;
    private readonly string _color;

    public SharedCarInfo(string make, string model, string color)
    {
        _make = make;
        _model = model;
        _color = color;
    }

    public string Make => _make;
    public string Model => _model;
    public string Color => _color;
}
