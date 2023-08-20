using System;
using System.Collections.Generic;

namespace Memento;

public class Life
{
    private string _time;

    public void SetTime(string time)
    {
        Console.WriteLine($"Skok do roku: {time}");
        _time = time;   
    }

    public Memento SaveMemento()
    {
        Console.WriteLine("Saved memento");
        return new Memento(_time);
    }

    public void RestoreMemento(Memento memento)
    {
        _time = memento.GetTime();
        Console.Write($"Przywrócono rok: ");
        Console.WriteLine(_time);
    }

    public class Memento
    {
        private readonly string _time;

        public Memento(string time) => _time = time;
        public string GetTime() => _time;
    }
}


public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Powrot do przyszlosci (Back to the Future)");
        Console.WriteLine();

        List<Life.Memento> savedMementos = new List<Life.Memento>();
        Life life = new Life();

        life.SetTime("1985");
        savedMementos.Add(life.SaveMemento());
        life.SetTime("1955");
        savedMementos.Add(life.SaveMemento());
        life.SetTime("2015");
        savedMementos.Add(life.SaveMemento());
        life.SetTime("1885");
        savedMementos.Add(life.SaveMemento());

        life.RestoreMemento(savedMementos[0]);
        life.RestoreMemento(savedMementos[3]);

    }
}