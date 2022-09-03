using System;
using System.Collections.Generic;

class Zycie
{
    private String czas;

    public void set(String czas)
    {
        Console.WriteLine($"Skok do roku: {czas}");
        this.czas = czas;
        
    }

    public Pamiatka zapiszPamiatke()
    {
        Console.WriteLine("stan zapisany");
        return new Pamiatka(czas);
    }

    public void przywrocPamiatke(Pamiatka pamiatka)
    {
        czas = pamiatka.pobierzCzas();
        Console.Write($"Przywrócono rok: ");
        Console.WriteLine(czas);
    }

    public class Pamiatka
    {
        private String czas;

        public Pamiatka(String czas)
        {
            this.czas = czas;
        }

        public String pobierzCzas()
        {
            return czas;
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





//using System;
//using System.Collections.Generic;

//class Zycie
//{
//    private String czas;

//    public void set(String czas)
//    {
//        //
//        //
//    }

//    public Pamiatka zapiszPamiatke()
//    {
//        //
//        //
//    }

//    public void przywrocPamiatke(Pamiatka pamiatka)
//    {
//        // czas = ??
//        //
//        //
//    }

//    public class Pamiatka
//    {
//        private String czas;

//        public Pamiatka(String czas)
//        {
//            //
//            //
//        }

//        public String pobierzCzas()
//        {
//            //
//            //
//        }
//    }
//}


//class MainClass
//{
//    public static void Main(string[] args)
//    {

//        Console.WriteLine("Powrot do przyszlosci (Back to the Future)");
//        Console.WriteLine();

//        List<Zycie.Pamiatka> zapisaneStany = new List<Zycie.Pamiatka>();
//        Zycie zycie = new Zycie();

//        zycie.set("1985");
//        zapisaneStany.Add(zycie.zapiszPamiatke());
//        zycie.set("1955");
//        zapisaneStany.Add(zycie.zapiszPamiatke());
//        zycie.set("2015");
//        zapisaneStany.Add(zycie.zapiszPamiatke());
//        zycie.set("1885");

//        zycie.przywrocPamiatke(zapisaneStany[0]);

//    }
//}














//using System;
//using System.Collections.Generic;

//class Zycie
//{
//    Pamiatka pamiatka;
//    private string czas;
//    public string Czas { 
//        get=> czas; 

//        set
//        {
//            if (int.Parse(value) > 0)
//            {
//                czas = value;
//                Console.WriteLine("Skok do roku: " + czas);
//            }
//        } 
//    }
//    public Pamiatka zapiszPamiatke()
//    {
//        Console.WriteLine("stan zapisany");
//        return pamiatka = new Pamiatka(czas);
//    }

//    public void przywrocPamiatke(Pamiatka pamiatka)
//    {
//        Console.Write($"Przywrócono rok: ");
//        czas = pamiatka.pobierzCzas();
//        Console.WriteLine(czas);
//    }
//}

//public class Pamiatka
//{
//    private string czas;

//    public Pamiatka(string czas)
//    {
//        this.czas = czas;
//    }

//    public string pobierzCzas()
//    {
//        return czas;
//    }
//}


//class MainClass
//{
//    public static void Main(string[] args)
//    {

//        Console.WriteLine("Powrot do przyszlosci (Back to the Future)");
//        Console.WriteLine();

//        List<Pamiatka> zapisaneStany = new List<Pamiatka>();
//        Zycie zycie = new Zycie();

//        zycie.Czas = "1985";
//        zapisaneStany.Add(zycie.zapiszPamiatke());
//        zycie.Czas = "1955";
//        zapisaneStany.Add(zycie.zapiszPamiatke());
//        zycie.Czas = "2015";
//        zapisaneStany.Add(zycie.zapiszPamiatke());
//        zycie.Czas = "1885";

//        zycie.przywrocPamiatke(zapisaneStany[0]);

//    }
//}

