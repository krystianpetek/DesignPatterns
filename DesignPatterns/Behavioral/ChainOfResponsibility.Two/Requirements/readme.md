# Chain of responsibility pattern

## Requirement description

Proszę napisać program który będzie wykorzystywać wzorzec łańcuch zobowiązań. W zależności od liczby powiadomień, obsługą powinny zajmować się różne obiekty.

brak, mało (<=5), dużo

Wynik działania:
Brak powiadomień
Mało powiadomień: 1
Dużo powiadomień: 12
Mało powiadomień: 3
Brak powiadomień

## Example for to be completed

```csharp
using System;

public interface Lancuch
{
    //
    //
    //
}

public class Powiadomienia
{
    private int number;

    public Powiadomienia(int number)
    {
        this.number = number;
    }

    public int pobierzLiczbe()
    {
        //
        //
    }
}

public class BrakLancuch : Lancuch
{
    private Lancuch nastepneWLancuchu;

    public void ustawNastepne(Lancuch c)
    {
        //
        //
    }

    public void przetwarzaj(Powiadomienia powiadomienia)
    {
        if (powiadomienia.pobierzLiczbe() <= 0)
        {
            //
            //
        }
        else
        {
            //
            //
            //
        }
    }
}

class Program
{
    static void Main(String[] args)
    {
        Lancuch l1 = new BrakLancuch();
        //
        //
        //

        int i = 0;
        l1.przetwarzaj(new Powiadomienia(i));
        i++;
        //
        //
        //
    }
}
```
