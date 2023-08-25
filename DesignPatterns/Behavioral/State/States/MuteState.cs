using System;
using State.Contracts;

namespace State.States;

class MuteState : IState
{
    public void Alert()
    {
        Console.WriteLine("wyciszenie...");
    }
}
