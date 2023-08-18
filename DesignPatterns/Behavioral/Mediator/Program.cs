using Mediator.Components;
using Mediator.Contracts;
using Mediator.Mediator;

namespace Mediator;

public static class Program
{
    public static void Main()
    {
        IMediator mediator = new ChatMediator();

        IUser ania = new Klient(mediator, "Ania");
        mediator.AddUser(ania);

        IUser nakamoto = new Dev(mediator, "Nakamoto");
        mediator.AddUser(nakamoto);

        IUser geohot = new Dev(mediator, "Geohot");
        mediator.AddUser(geohot);

        ania.SendMessage("Prosze natychmiast wprowadzic poprawki na produkcje.");
        geohot.SendMessage("Czekam az Nakamoto zaparzy kawe...");
    }
}