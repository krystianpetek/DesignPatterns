# Prototype pattern

## Requirement description

Tym razem oprogramowujemy sklep internetowy z żywnością.

Towar wkładany przez klienta do koszyka jest wirtualny. W rzeczywistości pracownik włoży go podczas kompletowania zamówienia.

Możemy porównać to do kuponów/bloczków/tokenów/znaczników które klient posiada w koszyku, a te później wymieniane są na rzeczywisty towar. My jako sklep możemy wyprodukować dowolną liczbę kuponów. Prościej mówiąc, będziemy je klonować.

Produkty które sprzedajemy to chleb i masło.

W związku z otwarciem i promocją sklepu internetowego, będziemy naliczać rabat 10% względem normalnych (stacjonarnych) cen na pierwszy bochenek chleba.

Bread - 9.50 zł > 8.55 zł

Bread - 9.50 zł

Butter - 5.30 zł

## Example for to be completed

```csharp
using System;
using System.Collections.Generic;

public abstract class <nazwa-klasy-bazowej>
{
  public ProductPrototype(decimal price)
{
    Price = price;
}

public ProductPrototype Clone()
{
    return (ProductPrototype)this.MemberwiseClone();
}
}

public class Bread : ProductPrototype
{
    public Bread(decimal price) : base(price) { }
}

public class Supermarket
{

    private Dictionary<string, ProductPrototype> _productList = new Dictionary<string, ProductPrototype>();

    public void AddProduct(string key, ProductPrototype productPrototype)
    {
        _productList.Add(key, productPrototype);
    }

    public ProductPrototype GetClonedProduct(string key)
    {
        return < powinno - zwracac - sklonowany - element - z - kolekcji >
    }

}


class MainClass
{
    public static void Main(string[] args)
    {
        Supermarket supermarket = new Supermarket();
        supermarket.AddProduct("Butter", new Butter(5.30m));


        var product = supermarket.GetClonedProduct("Butter");
        Console.WriteLine(String.Format("Bread - {0} zł", product.Price));
    }
}
```