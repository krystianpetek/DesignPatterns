using System;
using State.Contracts;

namespace State.States;

class VibrationState : IState
{
    public void Alert()
    {
        Console.WriteLine("wibracja...");
    }
}
