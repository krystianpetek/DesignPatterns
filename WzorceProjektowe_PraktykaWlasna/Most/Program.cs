using System;

namespace SMost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rodzaj x = new Osobowe();
            x.markaSamochodu = new Fiat();
            Console.WriteLine(x.ToString());
            x = new Terenowy();
            x.markaSamochodu = new Ford();
            Console.WriteLine(x.ToString());
        }
    }

    public abstract class Rodzaj {
        public IMarka markaSamochodu;
    }
    public interface IMarka { string nazwaMarki(); }
    public class Ford : IMarka
    {
        public string nazwaMarki()
        {
            return "Ford";
        }
        
    }
    public class Fiat: IMarka
    {
        public string nazwaMarki()
        {
            return "Fiat";
        }
    }

    public class Osobowe : Rodzaj
    {
        public override string ToString()
        {
            return "Samochod osobowy " + markaSamochodu.nazwaMarki();
        }
    }
    public class Terenowy: Rodzaj
    {
        public override string ToString()
        {
            return "Samochod osobowy " + markaSamochodu.nazwaMarki();
        }
    }
}