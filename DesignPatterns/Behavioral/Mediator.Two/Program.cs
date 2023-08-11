using System;

namespace Mediator.Two;

internal class Program
{
    static void Main(string[] args)
    {
        PowiadomienieGlobalne global = new PowiadomienieGlobalne();
        PowiadomienieLokalne lokalne = new PowiadomienieLokalne();
        Mediator media = new Mediator(global, lokalne);
        media.Powiadomienie("global");
        media.Powiadomienie("lokal");
    }
}

public interface IMediator
{
    public void Powiadomienie(string linia);
}
public class Mediator : IMediator
{
    PowiadomienieGlobalne _globalne;
    PowiadomienieLokalne _lokalne;
    public Mediator(PowiadomienieGlobalne globalne, PowiadomienieLokalne lokalne)
    {
        _globalne = globalne;
        _globalne.PrzypiszMediatora(this);
        _lokalne = lokalne;
        _lokalne.PrzypiszMediatora(this);
    }
    public void Powiadomienie(string linia)
    {
        if (linia == "global")
        {
            Console.WriteLine("Mediator reaguje na linie 'global', wywoluje powiadomienie globalne");
            _globalne.Global();
        }
        if (linia == "lokal")
        {
            Console.WriteLine("Mediator reaguje na linie 'lokal', wywoluje powiadomienie lokalne");
            _lokalne.Lokal();

        }
    }
}

public class BazaPowiadomien
{
    protected IMediator _mediator;
    public BazaPowiadomien(IMediator mediator = null)
    {
        _mediator = mediator;
    }
    public void PrzypiszMediatora(IMediator mediator)
    {
        _mediator = mediator;
    }

}

public class PowiadomienieGlobalne : BazaPowiadomien
{
    public void Global()
    {
        Console.WriteLine("POWIADOMEINIE GLOBALNE");
    }
}

public class PowiadomienieLokalne : BazaPowiadomien
{
    public void Lokal()
    {
        Console.WriteLine("POWIADOMEINIE Lokalne");

    }
}
