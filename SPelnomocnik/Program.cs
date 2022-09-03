using System;

namespace SPelnomocnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDostep dostep = new ProxyDoPlikow();
            dostep.UdzielDostepu(new Uzytkownik(Uzytkownik.rola.Admin));
        }
    }
    interface IDostep
    {
        void UdzielDostepu(Uzytkownik user);
    }
    public class Uzytkownik
    {
        public Uzytkownik(rola rola)
        {
            this.rolaUzytkownika = rola;
        }
        public string imie = "Krystian";
        public string nazwisko = "Petek";
        public int wiek = 23;
        public rola rolaUzytkownika;
        public enum rola { Admin,User}
    }

    public class Pliki : IDostep
    {
        public void UdzielDostepu(Uzytkownik user)
        {
            Console.WriteLine(user.imie + " " + user.nazwisko);
        }
    }
    public class ProxyDoPlikow : IDostep
    {
        IDostep pliki = new Pliki();
        public void UdzielDostepu(Uzytkownik user)
        {
            if(user.rolaUzytkownika == Uzytkownik.rola.Admin)
            {
                pliki.UdzielDostepu(user);
            }
            else
            {
                Console.WriteLine("Nie jesteś adminem");
            }
        }
    }
}
