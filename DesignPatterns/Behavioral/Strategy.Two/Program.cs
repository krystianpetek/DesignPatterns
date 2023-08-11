using System;

namespace Strategy.Two;

internal class Program
{
    static void Main(string[] args)
    {
        Operacja kalkulator = new Dodawanie();
        var wynik = kalkulator.Operacja(1, 5);
        kalkulator = new Modulo();
        Console.WriteLine(wynik);
        wynik = kalkulator.Operacja(4, 3);
        Console.WriteLine(wynik);
    }
}
public interface Operacja
{
    double Operacja(int a, int b);
}
public enum RodzajOperacji
{
    Dodawanie, Odejmowanie, Mnozenie, Dzielenie, Modulo
}
public class Dodawanie : Operacja
{
    public double Operacja(int a, int b)
    {
        return a + b;
    }
}
public class Odejmowanie : Operacja
{
    public double Operacja(int a, int b)

    {
        return a - b;
    }
}
public class Mnozenie : Operacja
{
    public double Operacja(int a, int b)

    {
        return a * b;
    }
}
public class Dzielenie : Operacja
{
    public double Operacja(int a, int b)

    {
        return a / b;
    }
}
public class Modulo : Operacja
{
    public double Operacja(int a, int b)

    {
        return a % b;
    }
}
