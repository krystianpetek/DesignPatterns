using System;

namespace Singleton;

public static class Program
{
    public static void Main()
    {
        Singleton x = Singleton.GetInstance();
        Singleton y = Singleton.GetInstance();

        Console.WriteLine($"{nameof(x)}: {x}");
        Console.WriteLine($"{nameof(y)}: {y}");
        Console.WriteLine(x == y ? "Same instance" : "Other instance");
    }
}
