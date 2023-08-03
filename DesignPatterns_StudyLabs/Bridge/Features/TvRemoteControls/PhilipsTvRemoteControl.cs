using System;
using Bridge.Contracts;

namespace Bridge.Features.TvRemoteControls;

public class PhilipsTvRemoteControl : ITvRemoteControl
{
    public ITelevision Television { get; set; }

    public PhilipsTvRemoteControl(ITelevision television)
    {
        Television = television;
    }

    public void TurnOn()
    {
        if (Television.State)
        {
            Console.WriteLine("The TV is already turned on.");
            return;
        }

        Television.TurnOn();
        Console.WriteLine("Philips TV Remote Control turns on television...");
    }

    public void TurnOff()
    {
        if (!Television.State)
        {
            Console.WriteLine("The TV is already turned off.");
            return;
        }

        Television.TurnOff();
        Console.WriteLine("Philips TV Remote Control turns off television...");
    }

    public void ChangeChannel(int channel)
    {
        if (!Television.State)
        {
            Console.WriteLine("The TV is turned off.");
            return;
        }

        Television.ChangeChannel(channel);
        Console.WriteLine("Philips TV Remote Control changes channel...");
    }
}
