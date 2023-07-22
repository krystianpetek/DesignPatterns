using System;
using System.Collections.Generic;


public interface IMediator
{
    void DodajUzytkownika(IUzytkownik uzytkownik);
    void WyslijWiadomosc(string wiadomosc, IUzytkownik nadawca);
}
public interface IUzytkownik
{
    void WyslijWiadomosc(string wiadomosc);
    void OdbierzWiadomosc(string wiadomosc);
}


public class Mediator : IMediator
{
    List<IUzytkownik> uzytkownicy;

    public Mediator()
    {
        uzytkownicy = new List<IUzytkownik>();
    }

    public void DodajUzytkownika(IUzytkownik uzytkownik)
    {
        if(uzytkownik != null)
        uzytkownicy.Add(uzytkownik);
    }

    public void WyslijWiadomosc(string wiadomosc, IUzytkownik nadawca)
    {
        foreach (var item in uzytkownicy)
        {
            if(item != nadawca)
            item.OdbierzWiadomosc(wiadomosc);
        }
    }
}

public class Dev : IUzytkownik
{
    string login;
    IMediator Mediator;

    public Dev(IMediator Mediator, string login)
    {
        this.login = login;
        this.Mediator = Mediator;
    }

    public void WyslijWiadomosc(string wiadomosc)
    {
        Mediator.WyslijWiadomosc(wiadomosc, this);
    }

    public void OdbierzWiadomosc(string wiadomosc)
    {
        Console.WriteLine("Programista " + login + " otrzymal wiadomosc: " + wiadomosc);
    }
}

public class Klient : IUzytkownik
{
    string login;
    IMediator Mediator;
    public Klient(IMediator Mediator, string login)
    {
        this.login = login;
        this.Mediator = Mediator;
    }
    public void OdbierzWiadomosc(string wiadomosc)
    {
        Console.WriteLine("Użytkownik " + login + " otrzymał wiadomość: " + wiadomosc);
    }

    public void WyslijWiadomosc(string wiadomosc)
    {
        Mediator.WyslijWiadomosc(wiadomosc, this);
    }
}

class Program
{
    static void Main(string[] args)
    {

        Mediator mediator = new Mediator();

        IUzytkownik ania = new Klient(mediator, "Ania");
        IUzytkownik nakamoto = new Dev(mediator, "Nakamoto");
        IUzytkownik geohot = new Dev(mediator, "Geohot");

        mediator.DodajUzytkownika(ania);
        mediator.DodajUzytkownika(nakamoto);
        mediator.DodajUzytkownika(geohot);

        ania.WyslijWiadomosc("Prosze natychmiast wprowadzic poprawki na produkcje.");
        geohot.WyslijWiadomosc("Czekam az Nakamoto zaparzy kawe...");
    }
}






//using System;
//using System.Collections.Generic;


////
////
////

//public class Mediator : IMediator
//{
//    List<IUzytkownik> uzytkownicy;

//    public Mediator()
//    {
//        uzytkownicy = new List<IUzytkownik>();
//    }

//    public void DodajUzytkownika(IUzytkownik uzytkownik)
//    {
//        //
//        //
//    }

//    public void WyslijWiadomosc(string wiadomosc, IUzytkownik nadawca)
//    {
//        //
//        //
//        //
//    }
//}

////
////
////

//public class Dev : IUzytkownik
//{
//    string login;
//    IMediator Mediator;

//    public Dev(IMediator Mediator, string login)
//    {
//        this.login = login;
//        this.Mediator = Mediator;
//    }

//    public void WyslijWiadomosc(string wiadomosc)
//    {
//        Mediator.WyslijWiadomosc(wiadomosc, this);
//    }

//    public void OdbierzWiadomosc(string wiadomosc)
//    {
//        Console.WriteLine("Programista " + login + " otrzymal wiadomosc: " + wiadomosc);
//    }
//}

////
////
////

//class Program
//{
//    static void Main(string[] args)
//    {

//        //

//        IUzytkownik ania = new Klient(mediator, "Ania");
//        //
//        //

//        //
//        mediator.DodajUzytkownika(nakamoto);
//        //

//        //
//        geohot.WyslijWiadomosc("Czekam az Nakamoto zaparzy kawe...");

//    }
//}