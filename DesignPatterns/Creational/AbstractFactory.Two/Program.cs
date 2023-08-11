using System;

namespace AbstractFactory.Two;

internal class Program
{
    static void Main(string[] args)
    {
        ZakupSamochodu zakup = new ZakupSamochodu(new FabrykaFiata());
        zakup.GenerujWynik();
        Console.WriteLine(zakup.osobowy);
        Console.WriteLine(zakup.dostawczy);
    }
}
public interface IFabrykaAbstrakcyjna
{
    public IOsobowy StworzOsobowy();
    public IDostawczy StworzDostaczy();
}
public interface IOsobowy { }
public class FordMondeo : IOsobowy { }
public class FiatTipo : IOsobowy { }

public interface IDostawczy { }
public class FordTransit : IDostawczy { }
public class FiatDucato : IDostawczy { }

public class FabrykaForda : IFabrykaAbstrakcyjna
{
    public IDostawczy StworzDostaczy()
    {
        return new FordTransit();
    }
    public IOsobowy StworzOsobowy()
    {
        return new FordMondeo();
    }
}
public class FabrykaFiata : IFabrykaAbstrakcyjna
{
    public IDostawczy StworzDostaczy()
    {
        return new FiatDucato();
    }
    public IOsobowy StworzOsobowy()
    {
        return new FiatTipo();
    }
}

public class ZakupSamochodu
{
    private IFabrykaAbstrakcyjna wyborMarki;
    public ZakupSamochodu(IFabrykaAbstrakcyjna marka)
    {
        wyborMarki = marka;
    }
    public IOsobowy osobowy;
    public IDostawczy dostawczy;

    public void GenerujWynik()
    {
        osobowy = wyborMarki.StworzOsobowy();
        dostawczy = wyborMarki.StworzDostaczy();
    }
}
