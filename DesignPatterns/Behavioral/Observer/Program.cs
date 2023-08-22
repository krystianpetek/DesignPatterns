using Observer.Contracts;
using Observer.Observers;
using Observer.Subjects;

namespace Observer;

public static class Program
{
    public static void Main()
    {
        var newsAgency = new NewsAgencySubject();

        var dailyEconomy = new DailyEconomyObserver();
        newsAgency.Attach(dailyEconomy);
        
        var newYork = new NewYorkTimesObserver();
        newsAgency.Attach(newYork);

        var nationalGeographic = new NationalGeographicObserver();
        newsAgency.Attach(nationalGeographic);

        newsAgency.SetNewsHeadline(Genre.Economy, "USA is going bancrupt!");
        newsAgency.SetNewsHeadline(Genre.Science, "Life on Alpha Centauri");
        newsAgency.SetNewsHeadline(Genre.Sport, "Adam Małysz is the greatest sportsman in the history of mankind");
        newsAgency.SetNewsHeadline(Genre.Economy, "CD Project RED value has grown by 500% in 2020");
        newsAgency.SetNewsHeadline(Genre.Science, "Kirkendall effect causing airplanes' engine deteriorate");
        newsAgency.SetNewsHeadline(Genre.Politics, "Texas is going bancrupt!");

        newsAgency.Detach(dailyEconomy);
        newsAgency.Detach(newYork);
        newsAgency.Detach(nationalGeographic);
    }
}