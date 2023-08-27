using State.Two.Contracts;
using State.Two.StateHolder;
using System;

namespace State.Two.States;

internal class SoldProduct : BaseState
{
    public override void ReturnCoin(StateMachine context)
    {
        Console.WriteLine("Automat wydaje produkt, nie mozna oddać monety");
    }

    public override void PushButton(StateMachine context)
    {
        Console.WriteLine("przycisk jest już wciśniety");
    }

    public override void PutCoin(StateMachine context)
    {
        Console.WriteLine("Automat wydaje produkt, nie można wrzucać monety");

    }

    public override void GiveProduct(StateMachine context)
    {
        context.Products--;
        if (context.Products > 0)
            context.State = new WithoutCoin();
        else
            context.State = new SoldoutProducts();
    }
}
