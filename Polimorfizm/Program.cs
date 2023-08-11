using System;

namespace Polimorfizm;

internal class Program
{
    static void Main(string[] args)
    {

    }
}
public interface ICzlowiek
{
    public bool idz();
    public void stoj();
    public bool ustaw_wiek(int w);
}
public class Student : ICzlowiek
{
    public int wiek { get; set; }
    public string imie { get; set; }
    private int pesel { get; set; }

    public bool idz()
    {
        throw new NotImplementedException();
    }

    public void stoj()
    {
        throw new NotImplementedException();
    }

    public bool ustaw_wiek(int w)
    {
        throw new NotImplementedException();
    }
}

public abstract class Czlowiek
{
    public abstract bool idz();
    public virtual void stoj() { }
    public abstract bool ustaw_wiek(int w);
}
public class Student2:Czlowiek
{
    public int wiek { get; set; }
    public string imie { get; set; }
    private int pesel { get; set; }
    public Student2():base()
    {}

    public override bool idz()
    {
        return false;
    }

    public override void stoj()
    {
        base.stoj();
    }

    public override bool ustaw_wiek(int w)
    {
        return false;
    }
}
