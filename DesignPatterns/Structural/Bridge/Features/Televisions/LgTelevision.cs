using System;
using Bridge.Contracts;

namespace Bridge.Features.Televisions;

public class LgTelevision : ITelevision
{
    public LgTelevision()
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
            Console.WriteLine("Television LG turned on.");
        }
    }

    public void TurnOff()
    {
        State = false;
        Console.WriteLine("Television LG turned off.");
    }

    public void ChangeChannel(int channel)
    {
        Channel = channel;
        Console.WriteLine($"Television LG, channel: {Channel}");
    }

    public void DisplayCurrentChannelAndState()
    {
        Console.WriteLine($"Current state for Television LG, channel: {Channel}, is turned on: {State}");
    }
}
