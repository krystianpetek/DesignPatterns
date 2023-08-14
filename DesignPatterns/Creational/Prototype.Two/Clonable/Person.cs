using System;
using Prototype.Two.Contracts;

namespace Prototype.Two.Clonable;

public class Person : IClone
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public DateTime BornDate { get; set; }
    public Person(string name, string surname, int age, DateTime bornDate)
    {
        Name = name;
        Surname = surname;
        Age = age;
        BornDate = bornDate;
    }

    public void DisplayMe()
    {
        Console.WriteLine($"Imię: {Name}\nNazwisko: {Surname}\nWiek: {Age}\nData urodzenia: {BornDate}");
    }

    public IClone DeepCopy()
    {
        Person copy = (Person)MemberwiseClone();
        copy.Name = new string(Name);
        copy.Surname = new string(Surname);
        copy.BornDate = BornDate;
        return copy;
    }
}
