# Template method pattern

## Requirement description

Proszę napisać aplikację która będzie obsługiwać 2 typy klientów - zamawiających online lub tradycyjnie (stacjonarnie).

Aplikacja powinna umożliwiać dodanie gratisu do dostawy.

Kompletowanie zamówienia...
Ustawiono parametry wysyłki...
Płatność...
Dodano gratis...
Wysyłka...
​
Wybranie produktów...
Płatność w kasie (karta/gotówka)...
Wydanie produktów (odbiór osobisty)...


## Example for to be completed

```csharp
using System;

abstract class ZamowienieTemplatka
{

    //
    //
    //

    public void dodanieGratisu()
    {
        Console.WriteLine("Dodano gratis...");
    }

    public void przetwarzajZamowienie(bool czyGratis)
    {
        //
        //
        //
    }
}


class ZamowienieOnline : ZamowienieTemplatka
{

    override public void doKoszyk()
    {
        Console.WriteLine("Kompletowanie zamówienia...");
        Console.WriteLine("Ustawiono parametry wysyłki...");
    }

    override public void doPlatnosc()
    {
        Console.WriteLine("Płatność...");
    }

    override public void doDostawa()
    {
        Console.WriteLine("Wysyłka...");
    }

}


class Program
{
    public static void Main(String[] args)
    {

        //
        //
        //

        ZamowienieTemplatka zamowienieStacjonarne = new ZamowienieStacjonarne();
        zamowienieStacjonarne.przetwarzajZamowienie(false);

    }
}
```
