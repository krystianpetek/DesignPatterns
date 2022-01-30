using System;
using System.Text;

abstract class ZamowienieTemplatka
{

    public abstract void doKoszyk();
    public abstract void doPlatnosc();
    public abstract void doDostawa();

    public void dodanieGratisu()
    {
        Console.WriteLine("Dodano gratis...");
    }

    public void przetwarzajZamowienie(bool czyGratis)
    {
        doKoszyk();
        doPlatnosc();
        if(czyGratis)
            dodanieGratisu();
        doDostawa();
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

class ZamowienieStacjonarne : ZamowienieTemplatka
{
    public override void doDostawa()
    {
        Console.WriteLine("Wydanie produktów (odbiór osobisty)...");

    }

    public override void doKoszyk()
    {
        Console.WriteLine("Wybranie produktów...");
    }

    public override void doPlatnosc()
    {
        Console.WriteLine("Płatność w kasie (karta/gotówka)...");
    }
}


class Program
{
    public static void Main(String[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        ZamowienieTemplatka zamowienieOnline = new ZamowienieOnline();
        zamowienieOnline.przetwarzajZamowienie(true);
        Console.WriteLine();

        ZamowienieTemplatka zamowienieStacjonarne = new ZamowienieStacjonarne();
        zamowienieStacjonarne.przetwarzajZamowienie(false);

    }
}










//using System;

//abstract class ZamowienieTemplatka
//{

//    //
//    //
//    //

//    public void dodanieGratisu()
//    {
//        Console.WriteLine("Dodano gratis...");
//    }

//    public void przetwarzajZamowienie(bool czyGratis)
//    {
//        //
//        //
//        //
//    }
//}


//class ZamowienieOnline : ZamowienieTemplatka
//{

//    override public void doKoszyk()
//    {
//        Console.WriteLine("Kompletowanie zamówienia...");
//        Console.WriteLine("Ustawiono parametry wysyłki...");
//    }

//    override public void doPlatnosc()
//    {
//        Console.WriteLine("Płatność...");
//    }

//    override public void doDostawa()
//    {
//        Console.WriteLine("Wysyłka...");
//    }

//}


//class Program
//{
//    public static void Main(String[] args)
//    {

//        //
//        //
//        //

//        ZamowienieTemplatka zamowienieStacjonarne = new ZamowienieStacjonarne();
//        zamowienieStacjonarne.przetwarzajZamowienie(false);

//    }
//}