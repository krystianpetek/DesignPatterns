using System;
using Bridge.Contracts;

namespace Bridge.Features.Televisions;

public class XiaomiTelevision : ITelevision
{
    public XiaomiTelevision()
    {
        Channel = 1;
        State = false;
    }

    public int Channel { get; set; }
    public bool State { get; set; }

    public void TurnOn()
    {
        if (!State)
        {
            State = true;
            Console.WriteLine("Television Xiaomi turned on.");
        }
    }

    public void TurnOff()
    {
        State = false;
        Console.WriteLine("Television Xiaomi turned off.");
    }

    public void ChangeChannel(int channel)
    {
        Channel = channel;
        Console.WriteLine($"Television Xiaomi, channel: {Channel}");
    }

    public void DisplayCurrentChannelAndState()
    {
        Console.WriteLine($"Current state for Television Xiaomi, channel: {Channel}, is turned on: {State}");
    }
}
