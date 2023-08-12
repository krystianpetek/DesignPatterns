namespace flyweight;

public static class Program
{
    static void Main(string[] args)
    {
        List<Car> cars = new List<Car>
        {
            new Car("Renault", "Clio", "Blue", "Name1", "ABC-sada123", "12dsada34567890"),
            new Car("Renault", "Clio", "Blue", "Nasdame1", "ABdsasdaC-123", "123sadsa4567890"),
            new Car("Opel", "Corsa", "Black", "Name2", "DEF-456", "1234567890"),
            new Car("Opel", "Corsa", "Black", "Name3", "DEF-4sd", "1234543267890"),
            new Car("Opel", "Corsa", "Black", "Name4", "DEF-ds", "1234123567890"),
            new Car("Opel", "Corsa", "Red", "Name5", "DEF-as", "1234543567890"),
        };

        var samochod = new Car("Opel", "Corsa", "Red", "Name5", "DEF-as", "1234543567890");
        var samochod2 = samochod;
        samochod2._owner = "krystian";
        Console.WriteLine(samochod._owner);

        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(SharedCarFactory.Count);
        Console.ResetColor();
    }
}
