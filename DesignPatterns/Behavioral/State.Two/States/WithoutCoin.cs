using State.Two.Contracts;
using State.Two.StateHolder;
using System;

namespace State.Two.States;

public class WithoutCoin : BaseState
{
    public override void ReturnCoin(StateMachine context)
    {
        Console.WriteLine("Nie ma pieniędzy w maszynie");
    }

    public override void PushButton(StateMachine context)
    {
        Console.WriteLine("Wrzuć monete");
    }

    public override void PutCoin(StateMachine context)
    {
        if (context.Products > 0)
        {
            context.State = new ThrownCoin();
            Console.WriteLine("Wrzucono monete");
        }
        else
        {
            Console.WriteLine("Brak produktów");
        }

    }

    public override void GiveProduct(StateMachine context)
    {
    }
}
