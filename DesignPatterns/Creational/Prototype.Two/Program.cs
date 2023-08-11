using System;

namespace Prototype.Two;

internal class Program
{
    static void Main(string[] args)
    {
        Osoba krystian = new Osoba("Krystian", "Petek", 23, new DateTime(1998, 10, 06));
        krystian.WyswietlMnie();
        Osoba krystianKlon = (Osoba)krystian.Kopia();
        krystian.imie = "Kry";
        krystianKlon.WyswietlMnie();
    }
}
public interface Klonuj
{
    Klonuj Kopia();
}
public class Osoba : Klonuj
{
    public string imie { get; set; }
    public string nazwisko { get; set; }
    public int wiek { get; set; }
    public DateTime dataUrodzenia { get; set; }
    public Osoba(string imie, string nazwisko, int wiek, DateTime data)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.wiek = wiek;
        dataUrodzenia = data;
    }

    public void WyswietlMnie()
    {
        Console.WriteLine($"Imię: {imie}\nNazwisko: {nazwisko}\nWiek: {wiek}\nData urodzenia: {dataUrodzenia}");
    }

    public Klonuj Kopia()
    {
        Osoba kopia = (Osoba)MemberwiseClone();
        kopia.imie = new string(imie);
        kopia.nazwisko = new string(nazwisko);
        kopia.dataUrodzenia = dataUrodzenia;
        return kopia;
    }
}
