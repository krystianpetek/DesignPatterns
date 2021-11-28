using System;
using System.Collections.Generic;
using System.Text;

namespace CS_klasy_kolekcje
{
    class Program
    {
        static List<string> lista = new List<string>();
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();
            Pig pig = new Pig();

            Console.WriteLine(suma(5, 4));
            helloWorld();

            Generator x = new Generator();
            
            // pierwsza lista
            for(int j = 0;j<100;j++)
                lista.Add(x.GenerujStringi());
            var find = lista.Find(x => x.Length > 5);
            Console.WriteLine($"index: {lista.IndexOf(find)} wartość: {find}");

            // druga lista
            lista.Clear();
            for (int j = 0;j<100;j++)
                lista.Add(x.GenerujStringi());
            int dlugoscNajkrotsza = lista[0].Length;
            int index = 0;
            for (int j = 0; j < lista.Count; j++)
                if (dlugoscNajkrotsza > lista[j].Length)
                {
                    dlugoscNajkrotsza = lista[j].Length;
                    index = j;
                }
            Console.WriteLine($"dlugość: {dlugoscNajkrotsza}, wartość: {lista[index]}");

            // trzecia lista
            lista.Clear();
            for (int j = 0; j < 100; j++)
                lista.Add(x.GenerujStringi());
            dlugoscNajkrotsza = lista[0].Length;
            index = 0;
            for (int j = 0; j < lista.Count; j++)
                if (dlugoscNajkrotsza > lista[j].Length)
                {
                    dlugoscNajkrotsza = lista[j].Length;
                    index = j;
                }
            Console.WriteLine($"index: {index}, wartość: {lista[index]}");
            
        }
        public static void helloWorld() => Console.WriteLine("hello world");
        public static int suma(int a, int b) => a + b; // funkcja lambda
    }

    public abstract class Animal
    {

        protected string name { get; set; }
        int _age { get; set; }
        int age
        {
            get { return _age; }
            set
            {
                if (value >= 2 || value <= 15)
                    _age = value;
            }
        }
        string sound { get; set; }
        public virtual void makeSound() => Console.WriteLine(sound);
    }

    public class Cat : Animal
    {

    }

    public class Dog : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("nie szczekam");
        }
    }

    public class Pig : Animal
    {

    }

    public class Generator
    {
        public Generator()
        {
            Random rand = new Random();
            _random = rand;
        }
        private char c;
        private Random _random;
        private int GenerujDlugosc => _random.Next(3, 10);
        private char wygenerowanyZnak => GenerujZnak();
        private int GenerujRodzaj() => _random.Next(0, 3);
        private char GenerujZnak()
        {
            switch (GenerujRodzaj())
            {
                case 0: // cyfry
                    c = (char)_random.Next(48, 58);
                    break;
                case 1: // duzeCyfry
                    c = (char)_random.Next(65, 91);
                    break;
                case 2: // maleCyfry
                    c = (char)_random.Next(97, 123);
                    break;
            }
            return c;
        }
        public string GenerujStringi()
        {
            StringBuilder slowo = new StringBuilder();
            for (int i = 0; i < GenerujDlugosc; i++)
            {
                slowo.Append(wygenerowanyZnak);
            }   
            return slowo.ToString();
        }
    }
}
