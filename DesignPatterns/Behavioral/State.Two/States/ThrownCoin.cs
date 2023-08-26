using State.Two.Contracts;
using System;

namespace State.Two.States;

public class ThrownCoin : BaseState
{
    public override void ReturnCoin(StateMachine context)
    {
        context.State = new WithoutCoin();
        Console.WriteLine("Zwrocono monete");
    }

    public override void PushButton(StateMachine context)
    {
        Console.WriteLine("sprzedano produkt");
        context.State = new SoldProduct();
    }

    public override void PutCoin(StateMachine context)
    {
        Console.WriteLine("Wciśnij przycisk, już wrzucono monete");

    }

    public override void GiveProduct(StateMachine context)
    {
    }
}
