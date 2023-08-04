# Composite pattern

## Requirement description

Instrukcja
Proszę napisać program budujący strukturę drzewiastą.

Podstawowa to korzeń (specjalny przypadek węzła). Elementy które mogą się pojawić to węzły i liście.

Korzeń i węzły mogą zawierać inne elementy, liście nie (kończą daną gałąź).

Korzeń rozpoczęcie renderowania
Leaf 1.1 renderowanie...
Węzeł 2 rozpoczęcie renderowania
Leaf 2.1 renderowanie...
Leaf 2.2 renderowanie...
Leaf 2.3 renderowanie...
Węzeł 2 zakończenie renderowania
Węzeł 3 rozpoczęcie renderowania
Leaf 3.1 renderowanie...
Leaf 3.2 renderowanie...
Węzeł 3.3 rozpoczęcie renderowania
Leaf 3.3.1 renderowanie...
Węzeł 3.3 zakończenie renderowania
Węzeł 3 zakończenie renderowania
Korzeń zakończenie renderowania

## Example for to be completed

```csharp
using System;
using System.Collections.Generic;

public interface Kompozyt
{
    void DodajElement(Kompozyt element);
    void UsunElement(Kompozyt element);
}

public class Lisc : Kompozyt
{
    public string nazwa { get; set; }

    public void Renderuj()
    {
        Console.WriteLine(nazwa + " renderowanie...");
    }

    // konstruktor

    // 2 brakujące metody których wymaga interfejs
}

public class Wezel : Kompozyt
{
    private List<Kompozyt> Lista = new List<Kompozyt>();
    public string nazwa { get; set; }

    public void Renderuj()
    {
        //rozpoczęcie renderowania
        //foreach item.Renderuj(); 
        //zakończenie renderowania
    }

    // 2 brakujące metody 
}

class MainClass
{
    public static void Main(string[] args)
    {
        //należy zainicjalizowac obiekt korzen    
        korzen.nazwa = "Korzeń";

        Wezel wezel2 = new Wezel();
        wezel2.nazwa = "Węzeł 2";
        korzen.DodajElement(wezel2);
        //  definicje struktury
        //

        korzen.Renderuj();
    }
}
```
