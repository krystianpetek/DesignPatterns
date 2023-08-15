using System;

namespace Command.Entities;

public class LampReceiver
{
    private bool _state = false;
    public void TurnOn() => _state = true;
    public void TurnOff() => _state = false;
    public void CheckState()
    {
        if (_state)
            Console.WriteLine("Lamp is on");
        else
            Console.WriteLine("Lamp is off");
    }
}