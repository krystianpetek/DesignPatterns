using System;
using Bridge.Contracts;

namespace Bridge.Features.TvRemoteControls;

public class PhilipsTvRemoteControl : TvRemoteControl
{
    private readonly ITelevision _television;

    public PhilipsTvRemoteControl(ITelevision television) : base(television)
    {
        _television = television;
    }

    public override void TurnOn()
    {
        if (_television.State)
        {
            Console.WriteLine("The TV is already turned on.");
            return;
        }

        _television.TurnOn();
        Console.WriteLine("Philips TV Remote Control turns on television...");
    }

    public override void TurnOff()
    {
        if (!_television.State)
        {
            Console.WriteLine("The TV is already turned off.");
            return;
        }

        _television.TurnOff();
        Console.WriteLine("Philips TV Remote Control turns off television...");
    }

    public override void ChangeChannel(int channel)
    {
        if (!_television.State)
        {
            Console.WriteLine("The TV is turned off.");
            return;
        }

        _television.ChangeChannel(channel);
        Console.WriteLine("Philips TV Remote Control changes channel...");
    }
}
