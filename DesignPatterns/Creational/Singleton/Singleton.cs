namespace Singleton;

public class Singleton
{
    private static readonly object _lock = new();
    private static Singleton _instance = null;
    private readonly int _number;

    private Singleton(int number) // required for prevent creating new instance
    { 
        _number = number;
    }

    public static Singleton GetInstance()
    {
        lock (_lock)
        {
            return _instance ??= new Singleton(1);
        }
    }
    
    public override string ToString() => $"{GetHashCode()}, object value: {_number}";
}
