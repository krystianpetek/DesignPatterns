using State.Two.Contracts;
using State.Two.StateHolder;
using System;

namespace State.Two.States;

public class SoldoutProducts : BaseState
{
    public override void ReturnCoin(StateMachine context)
    {
        Console.WriteLine("Automat pusty");
    }

    public override void PushButton(StateMachine context)
    {
        Console.WriteLine("Automat pusty");

    }

    public override void PutCoin(StateMachine context)
    {
        Console.WriteLine("Automat pusty");

    }

    public override void GiveProduct(StateMachine context)
    {
        Console.WriteLine("Automat pusty");

    }
}
