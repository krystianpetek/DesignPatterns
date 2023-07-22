using System;

namespace SDekorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISamochod samochod = new Osobowy();
            samochod = new Skora(samochod);
            samochod = new Felgi(samochod);
            Console.WriteLine(samochod.Opis());
            Console.WriteLine(samochod.Koszt());
        }
    }
    public interface ISamochod
    {
        string Opis();
        double Koszt();
    }
    public abstract class Samochod : ISamochod
    {
        public ISamochod _samochod;
        public Samochod(ISamochod samochod)
        {
            _samochod = samochod;
        }
        public abstract double Koszt();
        public abstract string Opis();
    }

    public class Osobowy : ISamochod
    {
        private double koszt = 120000.0;
        private string opis = "Standardowa wersja wyposażenia";
        public double Koszt()
        {
            return koszt;
        }

        public string Opis()
        {
            return opis;
        }
    }
    public class Felgi : Samochod
    {
        private string opis = " felgi aluminiowe";
        private double koszt = 8000.0;
        public Felgi(ISamochod samochod) : base(samochod)
        {
        }

        public override double Koszt()
        {
            return _samochod.Koszt() + koszt;
        }

        public override string Opis()
        {
            return _samochod.Opis() + opis;
        }
    }
    public class Skora : Samochod
    {
        private string opis = " skórzana tapicerka";
        private double koszt = 10000.0;
        public Skora(ISamochod samochod) : base(samochod)
        {
        }

        public override double Koszt()
        {
            return _samochod.Koszt() + koszt;
        }

        public override string Opis()
        {
            return _samochod.Opis() + opis;

        }
    }
}
