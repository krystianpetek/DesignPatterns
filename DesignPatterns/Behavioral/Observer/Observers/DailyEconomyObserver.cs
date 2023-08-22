using System;
using Observer.Contracts;
using Observer.Subjects;

namespace Observer.Observers;

class DailyEconomyObserver : IObserver
{
    public void Update(ISubject subject)
    {
        if ((subject as NewsAgencySubject).GetCurrentGenre() == Genre.Economy)
            Console.WriteLine($"DailyEconomy publish article \"{(subject as NewsAgencySubject).GetNewsHeadline()}\"");
    }
}