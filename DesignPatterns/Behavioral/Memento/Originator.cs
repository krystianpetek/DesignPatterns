using System;

namespace Memento;

public partial class Originator
{
    private string _time;

    public void SetTime(string time)
    {
        Console.WriteLine($"Let's go to the year: {time}");
        _time = time;   
    }

    public Snapshot SaveMemento()
    {
        Console.WriteLine("Saved time.");
        return new Snapshot(_time);
    }

    public void RestoreMemento(Snapshot snapshot)
    {
        _time = snapshot.GetTime();
        Console.Write($"Come back to year: {_time}");
    }
}
