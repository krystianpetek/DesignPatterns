using System;

namespace CZMetodaSzablonowa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TworzenieCzlowieka x = new Kobieta();
            x.MetodaSzablonowa();
        }
    }
    public abstract class TworzenieCzlowieka
    {
        public abstract void Plec();
        public void Glowa()
        {
            Console.WriteLine("Głowa");
        }
        public virtual void Wlosy()
        {
            Console.WriteLine("Bez włosów");
        }
        public void Rece()
        {
            Console.WriteLine("Ręce");
        }
        public void Tulow()
        {
            Console.WriteLine("Tułów");
        }
        public void Nogi()
        {
            Console.WriteLine("Nogi");
        }

        public void MetodaSzablonowa()
        {
            Plec();
            Glowa();
            Wlosy();
            Rece();
            Tulow();
            Nogi();
        }
    }
    public class Mezczyzna : TworzenieCzlowieka
    {
        public override void Plec()
        {
            Console.WriteLine("Mezczyzna");
        }
    }

    public class Kobieta : TworzenieCzlowieka
    {
        public override void Plec()
        {
            Console.WriteLine("Kobieta");
        }
    }
}
