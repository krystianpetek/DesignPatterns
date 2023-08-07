using System;
using Bridge.Contracts;

namespace Bridge.Features.TvRemoteControls;

public class HarmonyTvRemoteControl : TvRemoteControl
{
    private readonly ITelevision _television;

    public HarmonyTvRemoteControl(ITelevision television) : base(television)
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
        Console.WriteLine("Harmony TV Remote Control turns on television...");
    }

    public override void TurnOff()
    {
        if (!_television.State)
        {
            Console.WriteLine("The TV is already turned off.");
            return;
        }

        _television.TurnOff();
        Console.WriteLine("Harmony TV Remote Control turns off television...");
    }

    public override void ChangeChannel(int channel)
    {
        if (!_television.State)
        {
            Console.WriteLine("The TV is turned off.");
            return;
        }

        _television.ChangeChannel(channel);
        Console.WriteLine("Harmony TV Remote Control changes channel...");
    }
}
