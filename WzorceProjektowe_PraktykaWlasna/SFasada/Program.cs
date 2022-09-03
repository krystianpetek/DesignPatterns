using System;

namespace SFasada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fasada fasada = new Fasada();
            fasada.WykonajZadania135();
            fasada.WykonajZadania3451();
        }
    }

    public interface ToDo{
        void Zadanie();
    }
    public class Zadanie1 : ToDo
    {
        public void Zadanie()
        {
            Console.WriteLine("Zadanie1");
        }
    }
    public class Zadanie2 : ToDo
    {
        public void Zadanie()
        {
            Console.WriteLine("Zadanie2");

        }
    }
    public class Zadanie3 : ToDo
    {
        public void Zadanie()
        {
            Console.WriteLine("Zadanie3");
        }
    }
    public class Zadanie4 : ToDo
    {
        public void Zadanie()
        {
            Console.WriteLine("Zadanie4");
        }
    }
    public class Zadanie5 : ToDo
    {
        public void Zadanie()
        {
            Console.WriteLine("Zadanie5");
        }
    }
    public class Fasada
    {
        private Zadanie1 _zadanie1;
        private Zadanie2 _zadanie2;
        private Zadanie3 _zadanie3;
        private Zadanie4 _zadanie4;
        private Zadanie5 _zadanie5;
        public Fasada()
        {
            _zadanie1 = new Zadanie1();
            _zadanie2 = new Zadanie2();
            _zadanie3 = new Zadanie3();
            _zadanie4 = new Zadanie4();
            _zadanie5 = new Zadanie5();
        }
        public void WykonajZadania125()
        {
            Console.WriteLine("NOWE ZADANIE");
            _zadanie1.Zadanie();
            _zadanie2.Zadanie();
            _zadanie5.Zadanie();
        }
        public void WykonajZadania135()
        {
            Console.WriteLine("NOWE ZADANIE");
            _zadanie1.Zadanie();
            _zadanie3.Zadanie();
            _zadanie5.Zadanie();
        }
        public void WykonajZadania3451()
        {
            Console.WriteLine("NOWE ZADANIE");
            _zadanie3.Zadanie();
            _zadanie4.Zadanie();
            _zadanie5.Zadanie();
            _zadanie1.Zadanie();
        }
    }
}
