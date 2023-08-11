using System;

namespace FactoryMethod.Two;

internal class Program
{
    static void Main(string[] args)
    {
        var x = new FabrykaSamochodow();
        var gg = x.StworzSamochod(RodzajSamochodu.Osobowy);
        Console.WriteLine(gg);
    }
}
public enum RodzajSamochodu
{
    Osobowy, Terenowy, Ciezarowy
}
public interface ISamochod { }
public class Osobowy : ISamochod { }
public class Terenowy : ISamochod { }
public class Ciezarowy : ISamochod { }
public class FabrykaSamochodow
{
    public ISamochod StworzSamochod(RodzajSamochodu rodzaj)
    {
        switch (rodzaj)
        {
            case RodzajSamochodu.Osobowy:
                return new Osobowy();
            case RodzajSamochodu.Terenowy:
                return new Terenowy();
            case RodzajSamochodu.Ciezarowy:
                return new Ciezarowy();
            default: throw new ArgumentException();
        }
    }
}
