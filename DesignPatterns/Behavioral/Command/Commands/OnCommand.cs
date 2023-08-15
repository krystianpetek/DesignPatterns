using Command.Contracts;
using Command.Receiver;

namespace Command.Commands;

public class OnCommand : ICommand
{
    private readonly LampReceiver _lamp;

    public OnCommand(LampReceiver lamp) => _lamp = lamp;
    public void Execute() => _lamp.TurnOn();
}