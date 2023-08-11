//Lampa wyłączona
//Lampa włączona
//Lampa wyłączona

using System;

namespace Command;

public interface IPolecenie
{
    public void wykonaj();
}

public class KomendaWlacz : IPolecenie
{
    Lampa lampa;
    public KomendaWlacz(Lampa lampa)
    {
        this.lampa = lampa; 
    }
    public void wykonaj()
    {
        lampa.wlacz();
    }
}

public class KomendaWylacz : IPolecenie
{
    Lampa lampa;
    public KomendaWylacz(Lampa lampa)
    {
        this.lampa = lampa;
    }
    public void wykonaj()
    {
        lampa.wylacz();
    }
}


public class Lampa
{
    private bool stan { get; set; } = false;
    public void wlacz()
    {
        stan = true;
    }
    public void wylacz()
    {
        stan = false;
    }
    public bool sprawdz()
    {
        return stan;
    }
}


public class Pilot
{
    private IPolecenie polecenie;

    public void ustawPolecenie(IPolecenie przelacznik)
    {
        polecenie = przelacznik;
    }
    public void wcisnijGuzik()
    {
        polecenie.wykonaj();
    }

}


class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Lampa lampa = new Lampa();

        IPolecenie wlacz = new KomendaWlacz(lampa);
        IPolecenie wylacz = new KomendaWylacz(lampa);
        Pilot pilot = new Pilot();

        Console.WriteLine(lampa.sprawdz() ? "Lampa włączona" : "Lampa wyłączona");

        pilot.ustawPolecenie(wlacz);
        pilot.wcisnijGuzik();
        Console.WriteLine(lampa.sprawdz() ? "Lampa włączona" : "Lampa wyłączona");


        pilot.ustawPolecenie(wylacz);
        pilot.wcisnijGuzik();
        Console.WriteLine(lampa.sprawdz() ? "Lampa włączona" : "Lampa wyłączona");
    }
}




//using System;

//public interface IPolecenie
//{
//    /* UZUPEŁNIĆ */
//}

//public class KomendaWlacz : IPolecenie
//{
//    Lampa lampa;
//    public KomendaWlacz(Lampa lampa)
//    {
//        /* UZUPEŁNIĆ */
//    }
//    public void wykonaj()
//    {
//        lampa.wlacz();
//    }
//}

//public class KomendaWylacz : IPolecenie
//{
//    /* UZUPEŁNIĆ */
//}


//public class Lampa
//{
//    /* UZUPEŁNIĆ */

//    /* UZUPEŁNIĆ */

//    public bool sprawdz()
//    {
//        return stan;
//    }
//}


//public class Pilot
//{
//    private IPolecenie polecenie;

//    /* UZUPEŁNIĆ */

//}


//class Program
//{
//    static void Main(string[] args)
//    {
//        /* UZUPEŁNIĆ */

//        IPolecenie wlacz = new KomendaWlacz(lampa);
//        /* UZUPEŁNIĆ */

//        Console.WriteLine(lampa.sprawdz() ? "Lampa włączona" : "Lampa wyłączona");

//        pilot.ustawPolecenie(wlacz);
//        pilot.wcisnijGuzik();
//        /* UZUPEŁNIĆ */

//        pilot.ustawPolecenie(wylacz);
//        pilot.wcisnijGuzik();
//        /* UZUPEŁNIĆ */

//    }
//}