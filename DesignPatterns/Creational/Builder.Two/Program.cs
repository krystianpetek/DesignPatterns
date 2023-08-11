using System;
using System.Collections.Generic;

namespace Builder.Two;

internal class Program
{
    static void Main(string[] args)
    {
        var builder = new BudowniczyKrystian();
        var director = new Kierownik(builder);

        Console.WriteLine("Standardowy biedny produkt");
        director.BudujBiednyProdukt();
        Console.WriteLine(builder.GetProduct().ListParts());

        Console.WriteLine("Bogaty produkt");
        director.BudujBogatyProdukt();
        Console.WriteLine(builder.GetProduct().ListParts());

        Console.WriteLine("kustomowy produkt: ");
        builder.BudujA();
        builder.BudujC();
        Console.WriteLine(builder.GetProduct().ListParts());
    }
}
public interface IBudowniczy
{
    void BudujA();
    void BudujB();
    void BudujC();
    void Reset();
}
public class BudowniczyKrystian : IBudowniczy
{
    private Produkt _product;
    public BudowniczyKrystian()
    {
        Reset();
    }
    public void Reset()
    {
        _product = new Produkt();
    }
    public void BudujA()
    {
        _product.Add("Budulec A");
    }
    public void BudujB()
    {
        _product.Add("Budulec B");

    }
    public void BudujC()
    {
        _product.Add("Budulec C");

    }
    public Produkt GetProduct()
    {
        Produkt result = _product;
        Reset();
        return result;
    }
}
public class Produkt
{
    private List<object> _parts = new List<object>();

    public void Add(string part)
    {
        _parts.Add(part);
    }
    public string ListParts()
    {
        string str = string.Empty;

        for (int i = 0; i < _parts.Count; i++)
        {
            str += _parts[i] + ", ";
        }
        str = str.Remove(str.Length - 2);
        return "Product parts: " + str + "\n";
    }
}
public class Kierownik
{
    public Kierownik(IBudowniczy budowniczy)
    {
        Budowniczy = budowniczy;
    }
    private IBudowniczy _budowniczy;
    public IBudowniczy Budowniczy
    {
        set { _budowniczy = value; }
    }
    public void BudujBiednyProdukt()
    {
        _budowniczy.BudujA();
    }
    public void BudujBogatyProdukt()
    {
        _budowniczy.BudujA();
        _budowniczy.BudujB();
        _budowniczy.BudujC();
    }
}
