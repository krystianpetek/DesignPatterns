using Command.Commands;
using Command.Contracts;
using Command.Invoker;
using Command.Receiver;

namespace Command;

public static class Program
{
    public static void Main()
    {
        LampReceiver lamp = new LampReceiver();
        RemoteControlInvoker remoteControl = new RemoteControlInvoker();
        lamp.CheckState();

        ICommand onCommand = new OnCommand(lamp);
        remoteControl.SetCommand(onCommand);
        remoteControl.ExecuteCommand();
        lamp.CheckState();

        ICommand offCommand = new OffCommand(lamp);
        remoteControl.SetCommand(offCommand);
        remoteControl.ExecuteCommand();
        lamp.CheckState();
    }
}