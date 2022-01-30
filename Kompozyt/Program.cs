using System;
using System.Collections.Generic;

namespace SKompozyt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kompozyt drzewoPetek = new Kompozyt("Helena Petek");
            Kompozyt jozef = new Kompozyt("Jozef");
            jozef.Add(new Lisc("Patrycja"));
            jozef.Add(new Lisc("Krystian"));
            drzewoPetek.Add(jozef);
            Kompozyt gosia = new Kompozyt("Malgorzata");
            gosia.Add(new Lisc("Kinga"));
            gosia.Add(new Lisc("Łukasz"));
            gosia.Add(new Lisc("Aleksandra"));
            gosia.Add(new Lisc("Jan"));
            drzewoPetek.Add(gosia);
            Kompozyt jasiu = new Kompozyt("Jan");
            jasiu.Add(new Lisc("Natalia"));
            jasiu.Add(new Lisc("Paweł"));
            drzewoPetek.Add(jasiu);
            Lisc x = new Lisc("X");
            drzewoPetek.Add(x);
            drzewoPetek.Display(1);
        }
    }
    public abstract class Drzewko
    {
        protected string name;
        public Drzewko(string name)
        { this.name = name; }
        public abstract void Add(Drzewko c);
        public abstract void Remove(Drzewko c);
        public abstract void Display(int glebokosc);
    }
    public class Kompozyt : Drzewko
    {
        private List<Drzewko> lista = new List<Drzewko>();
        public Kompozyt(string name) : base(name)
        {
        }

        public override void Add(Drzewko c)
        {
            lista.Add(c);
        }

        public override void Remove(Drzewko c)
        {
            lista.Remove(c);
        }

        public override void Display(int glebokosc)
        {
            Console.WriteLine(new String('-',glebokosc) + name);
            foreach(Drzewko c in lista)
            {
                c.Display(glebokosc+1);
            }
        }
    }
    public class Lisc : Drzewko
    {
        public Lisc(string name) : base(name)
        {
        }

        public override void Add(Drzewko c)
        {
            Console.WriteLine("nie mozna dodać, obiekt jest liściem");
        }

        public override void Display(int glebokosc)
        {

            Console.WriteLine(new String('-', glebokosc) + name);

        }

        public override void Remove(Drzewko c)
        {
            Console.WriteLine("nie mozna usunąć, obiekt jest liściem");
        }
    }
}
