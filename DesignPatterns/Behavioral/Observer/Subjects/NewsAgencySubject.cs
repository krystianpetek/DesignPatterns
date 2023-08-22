using System.Collections.Generic;
using Observer.Contracts;

namespace Observer.Subjects;

public class NewsAgencySubject : ISubject
{
    private string _newsHeadline;
    private Genre _currentGenre;
    private readonly List<IObserver> _observers;

    public NewsAgencySubject()
    {
        _observers = new List<IObserver>();
    }

    public void SetNewsHeadline(Genre genre, string news)
    {
        _newsHeadline = news;
        _currentGenre = genre;
        Notify();
    }

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update(this);
        }
    }

    public string GetNewsHeadline()
    {
        return _newsHeadline;
    }

    public Genre GetCurrentGenre()
    {
        return _currentGenre;
    }
}