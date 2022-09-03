using System;
using System.Collections.Generic;

namespace CZObserwator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GrupaFB samochody = new GrupaSamochodowa();
            samochody.ObserwujGrupe(new Uzytkownik("Krystian"));
            samochody.ObserwujGrupe(new Uzytkownik("Gabriel"));
            samochody.Post = "Wjechał do sprzedaży Mercedes";
            samochody.ObserwujGrupe(new Uzytkownik("Józef"));
            samochody.Post = "Wyprzedano wszystkie Fiaty";
        }
    }

    public abstract class GrupaFB
    {
        private string nowyPost;
        List<IUzytkownik> listaOsob = new List<IUzytkownik>();
        public string Post
        {
            get { return nowyPost; }
            set
            {
                nowyPost = value;
                Powiadomienie();
            }
        }
        public void ObserwujGrupe(IUzytkownik osoba)
        {
            listaOsob.Add(osoba);
        }
        public void UsunObserwacjeGrupy(IUzytkownik osoba)
        {
            listaOsob.Remove(osoba);
        }
        public void Powiadomienie()
        {
            foreach (var x in listaOsob)
                x.Powiadom(this);
        }

    }
    public class GrupaSamochodowa : GrupaFB
    {}
    public interface IUzytkownik
    {
        public void Powiadom(GrupaFB grupa);
    }
    public class Uzytkownik : IUzytkownik
    {
        private string _nazwaUzytkownika;
        public Uzytkownik(string uzytkownik)
        {
            _nazwaUzytkownika = uzytkownik;
        }
        public void Powiadom(GrupaFB grupa)
        {
            Console.WriteLine($"{_nazwaUzytkownika}: dodano nowy post: {grupa.Post}");
        }
    }
}
