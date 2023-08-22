# Observer pattern

## Requirement description

DailyEconomy publikuje artykuł "USA is going bancrupt!"
NewYorkTimes publikuje artykuł "USA is going bancrupt!"

NewYorkTimes publikuje artykuł "Life on Alpha Centauri"
NationalGeographic publikuje artykuł "Life on Alpha Centauri"

NewYorkTimes publikuje artykuł "Adam Małysz is the greatest sportsman in the history of mankind"

DailyEconomy publikuje artykuł "CD Project RED value has grown by 500% in 2020"
NewYorkTimes publikuje artykuł "CD Project RED value has grown by 500% in 2020"

NewYorkTimes publikuje artykuł "Kirkendall effect causing airplanes' engine deteriorate"
NationalGeographic publikuje artykuł "Kirkendall effect causing airplanes' engine deteriorate"

NewYorkTimes publikuje artykuł "Texas is going bancrupt!"

## Example for to be completed

```csharp
using System;
using System.Collections.Generic;

namespace obserwator
{
    public enum Genre
    {
        Sport,
        Politics,
        Economy,
        Science
    }

    public interface IObserver
    {
        void Update(ISubject subject);
    }

    public interface ISubject
    {
        void Attach(IObserver observer);
        //
        //
    }

    public class NewsAgency : ISubject
    {
        public string NewsHeadline;
        public Genre State;

        public void setNewsHeadline(Genre state, string news)
        {
            //
            //
        }

        private List<IObserver> Observers = new List<IObserver>();

        //
        //
        //

        public void Detach(IObserver observer)
        {
            this.Observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in Observers)
            {
                observer.Update(this);
            }
        }
    }

    class DailyEconomy : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as NewsAgency).State == Genre.Economy)
            {
                Console.WriteLine($"DailyEconomy publikuje artykuł \"{(subject as NewsAgency).NewsHeadline}\"");
            }
        }
    }

    //
    //
    //
    //

    class Program
    {
        static void Main(string[] args)
        {
            var newsAgency = new NewsAgency();

            var dailyEconomy = new DailyEconomy();
            var newYork = new NewYorkTimes();
            var nationalGeographic = new NationalGeographic();

            //
            //
            //

            newsAgency.setNewsHeadline(Genre.Economy, "USA is going bancrupt!");
            //
            //
            //

            //deatach?

            //
            //
        }
    }
}
```
