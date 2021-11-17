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

//using System;
//using System.Collections.Generic;

//public interface Kompozyt {
//  void DodajElement(Kompozyt element);
//  void UsunElement(Kompozyt element);
//}

//public class Lisc : Kompozyt {
  
//  public string nazwa { get; set; }

//  public void Renderuj(){
//    Console.WriteLine( nazwa + " renderowanie...");
//  }


//  // konstruktor
    
//  // 2 brakujące metody których wymaga interfejs

//}


//public class Wezel : Kompozyt{

//  private List<Kompozyt> Lista=new List<Kompozyt>();

//  public string nazwa { get; set; }

//  public void Renderuj(){
//    //rozpoczęcie renderowania
    
//    //foreach item.Renderuj(); 
    
//    //zakończenie renderowania
//  }

//  // 2 brakujące metody 
  
//}


//class MainClass {
//  public static void Main (string[] args) {
//    //należy zainicjalizowac obiekt korzen    
//    korzen.nazwa = "Korzeń";

//    Wezel wezel2 = new Wezel();
//    wezel2.nazwa = "Węzeł 2";
//    korzen.DodajElement(wezel2);
//    //  definicje struktury
//    //
    
//    korzen.Renderuj();
    
//  }
//}