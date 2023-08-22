using System;
using System.Collections.Generic;

namespace Memento;

public class Caretaker
{
    private readonly Stack<Originator.Snapshot> _snapshots;
    private readonly Originator _originator;
    private string _currentTime;

    public Caretaker()
    {
        _snapshots = new Stack<Originator.Snapshot>();
        _originator = new Originator();
    }

    public void SetTime(string time)
    {
        _currentTime = time;
        _originator.SetTime(time);
        _snapshots.Push(_originator.SaveMemento());
    }

    public void Undo()
    {
        if (_snapshots.Count == 0)
        {
            return;
        }

        if (_snapshots.Peek().GetTime() == _currentTime)
        {
            _snapshots.Pop();
            _originator.RestoreMemento(_snapshots.Pop());
        }
        else
        {
            _originator.RestoreMemento(_snapshots.Pop());
        }
    }
}

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Back to the Future\n");

        var caretaker = new Caretaker();

        caretaker.SetTime("1985");
        caretaker.SetTime("1955");
        caretaker.SetTime("2015");
        caretaker.SetTime("1885");

        caretaker.Undo();
        caretaker.Undo();
    }
}