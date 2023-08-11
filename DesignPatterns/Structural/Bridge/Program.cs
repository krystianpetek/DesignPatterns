using System;
using Bridge.Contracts;
using Bridge.Features.Televisions;
using Bridge.Features.TvRemoteControls;

namespace Bridge;

public static class Program
{
    public static void Main()
    {
        ITelevision television = new LgTelevision();
        TvRemoteControl harmonyTvRemoteControl = new HarmonyTvRemoteControl(television);
        TvRemoteControl philipsTvRemoteControl = new PhilipsTvRemoteControl(television);

        television.DisplayCurrentChannelAndState();
        harmonyTvRemoteControl.TurnOn();
        television.DisplayCurrentChannelAndState();
        philipsTvRemoteControl.ChangeChannel(100);
        television.DisplayCurrentChannelAndState();
        harmonyTvRemoteControl.TurnOff();
        television.DisplayCurrentChannelAndState();
    }
}