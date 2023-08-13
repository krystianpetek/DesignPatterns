using System;

namespace Builder.Entities;

public class Computer
{
    private readonly string _type;
    public double Price { get; set; }
    public string Motherboard { get; set; }
    public string Screen { get; set; }
    public string HardDrive { get; set; }
    public string Processor { get; set; }

    public Computer(string computerType)
    {
        _type = computerType;
        Price = 0;
    }

    public void DisplayConfiguration()
    {
        Console.WriteLine("Typ: " + _type);
        Console.WriteLine("Płyta główna: " + Motherboard);
        Console.WriteLine("Procesor: " + Processor);
        Console.WriteLine("Dysk: " + HardDrive);
        Console.WriteLine("Monitor: " + Screen);
        Console.WriteLine("Cena: " + $"{Price:F2} zł");
    }
}
