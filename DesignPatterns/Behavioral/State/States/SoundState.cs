using System;
using State.Contracts;

namespace State.States;

class SoundState : IState
{
    public void Alert()
    {
        Console.WriteLine("dzwonek...");
    }
}
