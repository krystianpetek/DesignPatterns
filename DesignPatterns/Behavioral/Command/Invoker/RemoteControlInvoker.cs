using Command.Contracts;

namespace Command.Invoker;

public class RemoteControlInvoker
{
    private ICommand _command;

    public void SetCommand(ICommand command) => _command = command;
    public void ExecuteCommand() => _command.Execute();
}