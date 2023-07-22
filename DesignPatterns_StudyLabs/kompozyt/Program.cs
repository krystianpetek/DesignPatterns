using System;
using System.Collections.Generic;
using System.Text;

public interface Kompozyt
{
    void DodajElement(Kompozyt element);
    void UsunElement(Kompozyt element);
    void Renderuj();
}

public class Lisc : Kompozyt
{

    public string nazwa { get; set; }

    public void DodajElement(Kompozyt element)
    {
        throw new Exception("Dany element nie obsługuje dodawania elementów");
    }

    public void Renderuj()
    {
        Console.WriteLine(nazwa + " renderowanie...");
    }

    public void UsunElement(Kompozyt element)
    {
        Console.WriteLine();
    }

    public Lisc(string nazwa)
    {
        this.nazwa = nazwa;
    }
}


public class Wezel : Kompozyt
{

    private List<Kompozyt> Lista = new List<Kompozyt>();

    public string nazwa { get; set; }

    public void Renderuj()
    {
        Console.WriteLine($"{nazwa} rozpoczęcie renderowania");

        foreach (var item in Lista)
            item.Renderuj();

        Console.WriteLine($"{nazwa} zakończenie renderowania");
    }

    public void DodajElement(Kompozyt element)
    {
        Lista.Add(element);
    }

    public void UsunElement(Kompozyt element)
    {

        Lista.Remove(element);
    }
}


class MainClass
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        var korzen = new Wezel();    
        korzen.nazwa = "Korzeń";

        korzen.DodajElement(new Lisc("Liść 1.1"));
        
        Wezel wezel2 = new Wezel();
        wezel2.nazwa = "Węzeł 2";
        wezel2.DodajElement(new Lisc("Liść 2.1"));
        wezel2.DodajElement(new Lisc("Liść 2.2"));
        wezel2.DodajElement(new Lisc("Liść 2.3"));
        korzen.DodajElement(wezel2);
        Wezel wezel3 = new Wezel();
        wezel3.nazwa = "Węzeł 3";
        wezel3.DodajElement(new Lisc("Liść 3.1"));
        wezel3.DodajElement(new Lisc("Liść 3.2"));
        korzen.DodajElement(wezel3);
        Wezel wezel33 = new Wezel();
        wezel33.nazwa = "Węzeł 3.3";
        wezel33.DodajElement(new Lisc("Liść 3.3.1"));
        wezel3.DodajElement(wezel33);
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