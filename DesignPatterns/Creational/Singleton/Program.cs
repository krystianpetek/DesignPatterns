using System;

namespace Singleton;

internal class Program
{
    static void Main(string[] args)
    {
        Singleton x = Singleton.Instancja();
        Console.WriteLine(x);
        Singleton y = Singleton.Instancja();
        Console.WriteLine(y);
        Console.WriteLine(x == y ? "ta sama instacja" : "inna instancja");
    }
}
public class Singleton
{
    private static readonly object padlock = new object();
    private static Singleton instancja = null;
    public static Singleton Instancja()
    {
        lock (padlock)
        {
            if (instancja == null)
                instancja = new Singleton();
            return instancja;
        }
    }
}
