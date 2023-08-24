using Observer.Two.Contracts;
using Observer.Two.Publishers;
using Observer.Two.Subscribers;

namespace Observer.Two;

public static class Program
{
    static void Main(string[] args)
    {
        FacebookGroups samochody = new CarGroup();
        samochody.Subscribe(new User("Krystian"));
        samochody.Subscribe(new User("Gabriel"));
        samochody.Post = "New car in sale from Mercedes";
        samochody.Subscribe(new User("Jozef"));
        samochody.Post = "All Fiat's have been sold out";  
    }
}
