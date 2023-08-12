namespace flyweight;

static class SharedCarFactory
{
    private static readonly Dictionary<string, SharedCarInfo> _cars = new Dictionary<string, SharedCarInfo>();

    public static SharedCarInfo GetCar(string key)
    {
        if (!_cars.ContainsKey(key))
        {
            string[] parts = key.Split('_');
            if (parts.Length != 3)
                throw new ArgumentException("Invalid key");

            _cars[key] = new SharedCarInfo(parts[0], parts[1], parts[2]);
        }
        return _cars[key];
    }

    public static string Count => $"The factory has already produced {_cars.Count} shared cars info.";
}
