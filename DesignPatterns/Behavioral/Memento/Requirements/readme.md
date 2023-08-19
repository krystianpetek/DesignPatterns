# Memento pattern

## Requirement description

Powrót do przyszłości (Back to the Future)

Skok do roku: 1985
stan zapisany
Skok do roku: 1955
stan zapisany
Skok do roku: 2015
stan zapisany
Skok do roku: 1885
Przywrócono rok: 1985

## Example for to be completed

```csharp
using System;
using System.Collections.Generic;

class Zycie
{
    private String czas;

    public void set(String czas)
    {
        //
        //
    }

    public Pamiatka zapiszPamiatke()
    {
        //
        //
    }

    public void przywrocPamiatke(Pamiatka pamiatka)
    {
        // czas = ??
        //
        //
    }

    public class Pamiatka
    {
        private String czas;

        public Pamiatka(String czas)
        {
            //
            //
        }

        public String pobierzCzas()
        {
            //
            //
        }
    }
}


class MainClass
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Powrot do przyszlosci (Back to the Future)");
        Console.WriteLine();

        List<Zycie.Pamiatka> zapisaneStany = new List<Zycie.Pamiatka>();
        Zycie zycie = new Zycie();

        zycie.set("1985");
        zapisaneStany.Add(zycie.zapiszPamiatke());
        zycie.set("1955");
        zapisaneStany.Add(zycie.zapiszPamiatke());
        zycie.set("2015");
        zapisaneStany.Add(zycie.zapiszPamiatke());
        zycie.set("1885");

        zycie.przywrocPamiatke(zapisaneStany[0]);

    }
}
```
