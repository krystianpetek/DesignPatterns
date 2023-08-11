using System;

namespace ChainOfResponsibility.Three;

internal class Program
{
    static void Main(string[] args)
    {
        SystemWiadomosci infoLancuch = new SystemWiadomosci();
        infoLancuch.Wiadomosc("INFORMACJA", Priorytet.Medium);

    }
}
public class SystemWiadomosci
{
    private LancuchWiadomosci lancuchWiadomosci = null;
    public SystemWiadomosci()
    {
        lancuchWiadomosci = new Pracownik(new Kierownik(new Dyrektor(new Szef(null))));
    }
    public void Wiadomosc(string info, Priorytet priorytet)
    {
        lancuchWiadomosci.NastepnyOdbiorca(info, priorytet);
    }
}
public abstract class LancuchWiadomosci
{
    protected LancuchWiadomosci _nastepca;
    public abstract void NastepnyOdbiorca(string info, Priorytet priorytet);
}
public class Pracownik : LancuchWiadomosci
{
    public Pracownik(LancuchWiadomosci nastepca)
    {
        _nastepca = nastepca;
    }
    public override void NastepnyOdbiorca(string info, Priorytet priorytet)
    {
        if (priorytet == Priorytet.Low)
        {
            Console.WriteLine($"Wiadomość {info}");
            Console.WriteLine("Zadanie obsluzone przez pracownika");
        }
        else _nastepca.NastepnyOdbiorca(info, priorytet);

    }
}
public class Kierownik : LancuchWiadomosci
{
    public Kierownik(LancuchWiadomosci nastepca)
    {
        _nastepca = nastepca;
    }

    public override void NastepnyOdbiorca(string info, Priorytet priorytet)
    {
        if (priorytet == Priorytet.Medium)
        {
            Console.WriteLine($"Wiadomość {info}");
            Console.WriteLine("Zadanie obsluzone przez kierownika");
        }
        else _nastepca.NastepnyOdbiorca(info, priorytet);
    }
}
public class Dyrektor : LancuchWiadomosci
{
    public Dyrektor(LancuchWiadomosci nastepca)
    {
        _nastepca = nastepca;
    }
    public override void NastepnyOdbiorca(string info, Priorytet priorytet)
    {
        if (priorytet == Priorytet.High)
        {
            Console.WriteLine($"Wiadomość {info}");
            Console.WriteLine("Zadanie obsluzone przez dyrektora");
        }
        else _nastepca.NastepnyOdbiorca(info, priorytet);

    }
}
public class Szef : LancuchWiadomosci
{
    public Szef(LancuchWiadomosci nastepca)
    {
        _nastepca = nastepca;
    }
    public override void NastepnyOdbiorca(string info, Priorytet priorytet)
    {
        Console.WriteLine($"Wiadomość {info}");
        Console.WriteLine("Zadanie obsłużone przez szefa");
    }
}
public enum Priorytet
{
    Low, Medium, High, VeryHigh, Important
}
