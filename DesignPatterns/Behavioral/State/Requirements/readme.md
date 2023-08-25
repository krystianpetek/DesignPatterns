# State pattern

## Requirement description

Proszę napisać aplikację, która wyświetlać będzie stan dzwonka/wibracji/wyciszenia telefonu. Metoda alert() w każdym ze stanów powinna wypisać w jakim stanie się znajduje telefon (w rzeczywistości byłaby to ikonka na górnej belce).

wibracja...
dzwonek...
wyciszenie...
wyciszenie...
wibracja...

## Example for to be completed

```csharp
using System;

interface Stan
{

    void alert();

}

class Powiadomienia
{

    private Stan aktualnyStan;

    public Powiadomienia()
    {
        aktualnyStan = //domyślny
  }

    //ustawStan(Stan stan)
    //

    //
    //

}

class Dzwonek : Stan
{

    //

}



class Program
{
    public static void Main(string[] args)
    {
        //
        //
        //
        //
        //
        //
        powiadomienia.alert();
        powiadomienia.ustawStan(new Wibracja());
        powiadomienia.alert();
    }
}
```
