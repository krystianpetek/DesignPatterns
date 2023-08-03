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
        ITvRemoteControl harmonyTvRemoteControl = new HarmonyTvRemoteControl(television);
        ITvRemoteControl philipsTvRemoteControl = new PhilipsTvRemoteControl(television);

        television.DisplayCurrentChannelAndState();
        harmonyTvRemoteControl.TurnOn();
        television.DisplayCurrentChannelAndState();
        philipsTvRemoteControl.ChangeChannel(100);
        television.DisplayCurrentChannelAndState();
        harmonyTvRemoteControl.TurnOff();
        television.DisplayCurrentChannelAndState();
    }
}