using System;

namespace State.Two;

internal class Program
{
    static void Main(string[] args)
    {
        var maszyna = new Maszyna();
        Console.WriteLine("maszyna z produkatami");
        Console.WriteLine("1. Wrzuć monete");
        Console.WriteLine("2. Zwroc monete");
        Console.WriteLine("3. Wciśnij przycisk");
        Console.WriteLine("4. Wyłącz");

        while (true)
        {
            Console.WriteLine("Wprowadz komende");
            string komenda = Console.ReadLine();
            switch (komenda)
            {
                case "1":
                    maszyna.WrzucMonete();
                    break;
                case "2":
                    maszyna.OddajMonete();
                    break;
                case "3":
                    maszyna.WciśnijPrzycisk();
                    break;
                default: break;
            }
        }
    }
}
public abstract class Stan
{
    public abstract void WrzucMonete(Maszyna context);
    public abstract void OddajMonete(Maszyna context);
    public abstract void WciśnijPrzycisk(Maszyna context);
    public abstract void WydajProdukt(Maszyna context);
}

public class NieMaPiniazka : Stan
{
    public override void OddajMonete(Maszyna context)
    {
        Console.WriteLine("Nie ma pieniędzy w maszynie");
    }

    public override void WciśnijPrzycisk(Maszyna context)
    {
        Console.WriteLine("Wrzuć monete");
    }

    public override void WrzucMonete(Maszyna context)
    {
        if (context.Produkty > 0)
        {
            context.Stan = new WrzuconoPiniazka();
            Console.WriteLine("Wrzucono monete");
        }
        else
        {
            Console.WriteLine("Brak produktów");
        }

    }

    public override void WydajProdukt(Maszyna context)
    {
    }
}
public class WrzuconoPiniazka : Stan
{
    public override void OddajMonete(Maszyna context)
    {
        context.Stan = new NieMaPiniazka();
        Console.WriteLine("Zwrocono monete");
    }

    public override void WciśnijPrzycisk(Maszyna context)
    {

        Console.WriteLine("sprzedano produkt");
        context.Stan = new Sprzedano();
    }

    public override void WrzucMonete(Maszyna context)
    {
        Console.WriteLine("Wciśnij przycisk, już wrzucono monete");

    }

    public override void WydajProdukt(Maszyna context)
    {
    }
}

internal class Sprzedano : Stan
{
    public override void OddajMonete(Maszyna context)
    {
        Console.WriteLine("Automat wydaje produkt, nie mozna oddać monety");
    }

    public override void WciśnijPrzycisk(Maszyna context)
    {
        Console.WriteLine("przycisk jest już wciśniety");
    }

    public override void WrzucMonete(Maszyna context)
    {
        Console.WriteLine("Automat wydaje produkt, nie można wrzucać monety");

    }

    public override void WydajProdukt(Maszyna context)
    {
        context.Produkty--;
        if (context.Produkty > 0)
            context.Stan = new NieMaPiniazka();
        else
            context.Stan = new Wyprzedano();
    }
}
public class Wyprzedano : Stan
{
    public override void OddajMonete(Maszyna context)
    {
        Console.WriteLine("Automat pusty");
    }

    public override void WciśnijPrzycisk(Maszyna context)
    {
        Console.WriteLine("Automat pusty");

    }

    public override void WrzucMonete(Maszyna context)
    {
        Console.WriteLine("Automat pusty");

    }

    public override void WydajProdukt(Maszyna context)
    {
        Console.WriteLine("Automat pusty");

    }
}

public class Maszyna
{
    private Stan _stan;
    private int produkty = 10;
    public Maszyna()
    {
        Stan = new NieMaPiniazka();
    }
    public Stan Stan
    {
        get { return _stan; }
        set { _stan = value; }
    }
    public int Produkty
    {
        get { return produkty; }
        set { produkty = value; }
    }
    public void WrzucMonete()
    {
        _stan.WrzucMonete(this);
    }
    public void OddajMonete()
    {
        _stan.OddajMonete(this);

    }
    public void WciśnijPrzycisk()
    {
        _stan.WciśnijPrzycisk(this);
        _stan.WydajProdukt(this);
    }
}
