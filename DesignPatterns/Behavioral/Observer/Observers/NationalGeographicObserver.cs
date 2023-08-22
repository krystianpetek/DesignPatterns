using System;
using Observer.Contracts;
using Observer.Subjects;

namespace Observer.Observers;

internal class NationalGeographicObserver : IObserver
{
    public void Update(ISubject subject)
    {
        if ((subject as NewsAgencySubject).GetCurrentGenre() == Genre.Science)
            Console.WriteLine($"NationalGeographic publish article \"{(subject as NewsAgencySubject).GetNewsHeadline()}\"");
    }
}