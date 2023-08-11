using System;

namespace RELACJE;

internal class Program
{
    static void Main(string[] args)
    {
        // asocjacja - Obiekty jednej klasy działają wykorzystując obiekty innej przez pewien dłuższy czas
        Class2 c2 = new Class2();
        c2.id = 7;
        Class c1 = new Class();
        c1.Print(c2);
    }
}

// zależność - Klasa chwilowo korzysta z drugiej lub wie o jej istnieniu.
public class Student
{

    void Dodaj(Ocena o)
    {

    }
}
public class Ocena
{

}

// asocjacja - Obiekty jednej klasy działają wykorzystując obiekty innej przez pewien dłuższy czas
public class Class
{
    public int id { get; set; }
    public void Print(Class2 klasa)
    {
        Console.WriteLine(klasa);
    }
}
public class Class2
{
    public int id { get; set; }
    public void Print()
    {
        Console.WriteLine();
    }
}

// agregacja częściowa - usunięcie elementu głównego nie usuwa elementu w relacji
public class Biblioteka
{
    private Ksiazka nazwa;
    public void SetNazwa (Ksiazka dokument)
    {
        nazwa = dokument;
    }

    // agregacja całkowita, usunięcie elemetnu gloownego sprawi, ze obiekt klasy zależnej przestanie istnieć
    private Ksiazka _nazwa2 = new Ksiazka();
}
public class Ksiazka
{

}

// dziedziczenie
interface IInterface1
{
    void AddMoney();
}
class Wallet:IInterface1
{
    public void AddMoney()
    {

    }
}
