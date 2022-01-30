using System;
using System.Collections.Generic;

namespace SPylek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FabrykaPostaci fabryka = new FabrykaPostaci();
            fabryka.DodajPostac("Geralt", 1, 300);
            fabryka.DodajPostac("Geralt", 1, 300);
            fabryka.DodajPostac("Yennefer", 3, 300);

            fabryka.WyswietlPostacie();
        }
    }

    class Postac
    {
        public string name { get; set; }
        public float maxHP { get; set; }
        public int level { get; set; } = 1;
        public double speed { get; set; }
    }
    public class FabrykaPostaci
    {
        Dictionary<string, Postacie> listaPostaci = new Dictionary<string, Postacie>();
        public Postacie DodajPostac(string nazwa, int level, float maxHP)
        {
            string ciag = Postacie.GetKey(nazwa,level,maxHP);
            if (!listaPostaci.ContainsKey(ciag))
            {
                listaPostaci.Add(ciag,new Postacie(nazwa, level,maxHP));
            }
            return listaPostaci[ciag];
        }

        public void WyswietlPostacie()
        {
            foreach (var x in listaPostaci)
                Console.WriteLine(x.Value.Wyswietl());
        }
    }
    public class Postacie
    {
        private Postac postac;
        public Postacie(string nazwa, int level, float maxHP)
        {
            postac = new Postac();
            postac.name = nazwa;
            postac.maxHP = maxHP;
            postac.level = level;
            postac.speed = 1.0;
        }
        public static string GetKey(string nazwa, int level, float maxHP)
        {
            return nazwa + "_" + level + "_" + maxHP;
        }
        public string Wyswietl()
        {
            return this.postac.name + " " + this.postac.level;
        }
    }

}
