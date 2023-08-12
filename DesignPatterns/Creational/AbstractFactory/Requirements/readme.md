# Abstract factory pattern

## Requirement description

Proszę napisać aplikację, która tworzyć będzie obiekty zawierające alfabet (fragment) i cyfry (również fragment) w danym systemie.

Obsługa 3 systemów: łaciny, cyrylicy i greki.

W wyniku działania powinniśmy uzyskać:

abcde I II III
абвгд 1 2 3
αβγδε αʹ βʹ γʹ

## Example for to be completed

```csharp
using System;
using System.Text;


interface ILitery
{
    public string ShowAlfa();
}

//
//
//

class AlfabetFactory
{

    private SystemFactory systemFactory;

    //
    //

    public AlfabetFactory(SystemFactory systemFactory)
    {
        //
    }

    public void Generate()
    {
        numbers = systemFactory.CreateNum();
        //
    }
}


abstract class SystemFactory
{
    //
    public abstract ICyfry CreateNum();
}

//
// ...
//

class CyrylicaFactory : SystemFactory
{
    public override ILitery CreateAlfa()
    {
        return new CyrylicaLetters();
    }

    public override ICyfry CreateNum()
    {
        return new CyrylicaNumbers();
    }
}

//
// ...
//

class GrekaNumbers : ICyfry
{
    string numbers;

    //
    //
    //  

    public string ShowNum()
    {
        return numbers;
    }
}

class LacinkaLetters : ILitery
{
    string letters;

    public LacinkaLetters()
    {
        letters = "abcde";
    }

    //
    //
    //
}

//
// ...
//

public class Application
{
    public static void Main(String[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        AlfabetFactory alfabet_lacinka = new AlfabetFactory(new LacinkaFactory());
        //

        //
        alfabet_cyrylica.Generate();

        //
        //

        // 
        //3x show ;)
        //
    }
}
```
