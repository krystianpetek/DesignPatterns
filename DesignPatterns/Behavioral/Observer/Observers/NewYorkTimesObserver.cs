using System;
using Observer.Contracts;
using Observer.Subjects;

namespace Observer.Observers;

internal class NewYorkTimesObserver : IObserver
{
    public void Update(ISubject subject)
    {
        if ((subject as NewsAgencySubject).GetCurrentGenre() == Genre.Science)
            Console.WriteLine($"NewYorkTimes publish article \"{(subject as NewsAgencySubject).GetNewsHeadline()}\"");
        if ((subject as NewsAgencySubject).GetCurrentGenre() == Genre.Sport)
            Console.WriteLine($"NewYorkTimes publish article \"{(subject as NewsAgencySubject).GetNewsHeadline()}\"");
        if ((subject as NewsAgencySubject).GetCurrentGenre() == Genre.Economy)
            Console.WriteLine($"NewYorkTimes publish article \"{(subject as NewsAgencySubject).GetNewsHeadline()}\"");
        if ((subject as NewsAgencySubject).GetCurrentGenre() == Genre.Politics)
            Console.WriteLine($"NewYorkTimes publish article \"{(subject as NewsAgencySubject).GetNewsHeadline()}\"");
    }
}