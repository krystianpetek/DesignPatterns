using Command.Contracts;
using Command.Entities;

namespace Command.Commands;

public class OffCommand : ICommand
{
    private readonly LampReceiver _lamp;
    public OffCommand(LampReceiver lamp) => _lamp = lamp;
    public void Execute() => _lamp.TurnOff();
}