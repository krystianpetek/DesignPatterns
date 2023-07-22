using System;

public interface Lancuch
{
    public void przetwarzaj(Powiadomienia powiadomienia);
    public void ustawNastepne(Lancuch c);
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
        return number;
    }
}

public class BrakLancuch : Lancuch
{
    private Lancuch nastepneWLancuchu;
    public void ustawNastepne(Lancuch c)
    {
        nastepneWLancuchu = c;        
    }

    public void przetwarzaj(Powiadomienia powiadomienia)
    {
        if (powiadomienia.pobierzLiczbe() <= 0)
        {
            Console.WriteLine("Brak powiadomień");
        }
        else
        {
            nastepneWLancuchu.przetwarzaj(powiadomienia);
        }
    }
}
public class MaloPowiadomien : Lancuch
{
    private Lancuch nastepneWLancuchu;
    public void przetwarzaj(Powiadomienia powiadomienia)
    {
        if (powiadomienia.pobierzLiczbe() <= 5)
        {
            Console.WriteLine("Mało powiadomień: " + powiadomienia.pobierzLiczbe());
        }
        else
        {
            nastepneWLancuchu.przetwarzaj(powiadomienia);
        }
    }
    public void ustawNastepne(Lancuch c)
    {
        nastepneWLancuchu = c;
    }
}
public class DuzoPowiadomien : Lancuch
{
    private Lancuch nastepneWLancuchu;
    public void przetwarzaj(Powiadomienia powiadomienia)
    {
        Console.WriteLine($"Duzo powiadomień: {powiadomienia.pobierzLiczbe()}");
        
    }

    public void ustawNastepne(Lancuch c)
    {
        nastepneWLancuchu = c;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Lancuch l1 = new BrakLancuch();
        Lancuch l2 = new MaloPowiadomien();
        Lancuch l3 = new DuzoPowiadomien();
        l1.ustawNastepne(l2);
        l2.ustawNastepne(l3);

        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int i = 0;
        l1.przetwarzaj(new Powiadomienia(i));
        i++;
        l1.przetwarzaj(new Powiadomienia(i));
        i = 12;
        l1.przetwarzaj(new Powiadomienia(i));
        i = 3;
        l1.przetwarzaj(new Powiadomienia(i));
        i = 0;
        l1.przetwarzaj(new Powiadomienia(i));
    }
}









//using System;

//public interface Lancuch
//{
//    //
//    //
//    //
//}

//public class Powiadomienia
//{

//    private int number;

//    public Powiadomienia(int number)
//    {
//        this.number = number;
//    }

//    public int pobierzLiczbe()
//    {
//        //
//        //
//    }

//}

//public class BrakLancuch : Lancuch
//{

//    private Lancuch nastepneWLancuchu;

//    public void ustawNastepne(Lancuch c)
//    {
//        //
//        //
//    }

//    public void przetwarzaj(Powiadomienia powiadomienia)
//    {
//        if (powiadomienia.pobierzLiczbe() <= 0)
//        {
//            //
//            //
//        }
//        else
//        {
//            //
//            //
//            //
//        }
//    }
//}


//class Program
//{
//    static void Main(String[] args)
//    {

//        Lancuch l1 = new BrakLancuch();
//        //
//        //
//        //

//        int i = 0;
//        l1.przetwarzaj(new Powiadomienia(i));
//        i++;
//        //
//        //
//        //

//    }
//}