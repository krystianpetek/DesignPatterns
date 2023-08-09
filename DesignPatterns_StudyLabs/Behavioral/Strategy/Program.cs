﻿using System;

namespace Strategy;

abstract class Zawodnik
{

    KopniecieTyp kopniecieTyp;
    SkokTyp skokTyp;

    public Zawodnik(KopniecieTyp kopniecieTyp, SkokTyp skokTyp)
    {
        this.kopniecieTyp = kopniecieTyp;
        this.skokTyp = skokTyp;
    }

    public void uderzenie()
    {
        Console.WriteLine("Uderzenie");
    }

    public void kopniecie()
    {
        kopniecieTyp.kopniecie();
    }

    public void skok()
    {
        skokTyp.skok();
    }

    public void ustawKopniecieTyp(KopniecieTyp kopniecieTyp)
    {
        this.kopniecieTyp = kopniecieTyp;
    }

    public void ustawSkokTyp(SkokTyp skokTyp)
    {
        this.skokTyp = skokTyp;
    }

    public abstract void przedstaw();

}

interface KopniecieTyp
{
    void kopniecie();
}

class KopniecieLod : KopniecieTyp
{
    public void kopniecie()
    {
        Console.WriteLine("Kopnięcie lodowe");
    }
}

class KopniecieOgien : KopniecieTyp
{
    public void kopniecie()
    {
        Console.WriteLine("Kopnięcie z ogniem");
    }
}

interface SkokTyp
{
    void skok();
}
class SkokKrotki : SkokTyp
{
    public void skok()
    {
        Console.WriteLine("Krótki skok");
    }
}
class SkokDlugi : SkokTyp
{
    public void skok()
    {
        Console.WriteLine("Długi skok");
    }
}

class SubZero : Zawodnik
{
    public SubZero(KopniecieTyp kopniecieTyp, SkokTyp skokTyp) : base(kopniecieTyp, skokTyp)
    {
    }

    override public void przedstaw()
    {
        Console.WriteLine("Jestem Sub-Zero!");
    }
}

class Scorpion : Zawodnik
{
    public Scorpion(KopniecieTyp kopniecieTyp, SkokTyp skokTyp) : base(kopniecieTyp, skokTyp)
    {
    }

    override public void przedstaw()
    {
        Console.WriteLine("Jestem Scorpion!");
    }
}


class MainClass
{

    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("-- Mortal Kombat --");
        Console.WriteLine();

        SkokTyp krotkiSkok = new SkokKrotki();
        SkokTyp dlugiSkok = new SkokDlugi();

        KopniecieTyp kopniecieLod = new KopniecieLod();
        KopniecieTyp kopniecieOgien = new KopniecieOgien();

        Zawodnik subZero = new SubZero(kopniecieLod, krotkiSkok);
        subZero.przedstaw();
        subZero.uderzenie();
        subZero.kopniecie();
        subZero.skok();
        subZero.ustawSkokTyp(dlugiSkok);
        subZero.skok();

        Console.WriteLine();
        Zawodnik scorpion = new Scorpion(kopniecieOgien, dlugiSkok);
        scorpion.przedstaw();
        scorpion.uderzenie();
        scorpion.kopniecie();
        scorpion.ustawKopniecieTyp(kopniecieLod);
        scorpion.kopniecie();
        scorpion.skok();
    }
}