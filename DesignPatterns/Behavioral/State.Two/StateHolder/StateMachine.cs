using State.Two.Contracts;
using State.Two.States;

namespace State.Two.StateHolder;

public class StateMachine
{
    public StateMachine()
    {
        State = new WithoutCoin();
    }
    public BaseState State { get; set; }
    public int Products { get; set; } = 10;
    public void PutCoin()
    {
        State.PutCoin(this);
    }
    public void ReturnCoin()
    {
        State.ReturnCoin(this);

    }
    public void PushButton()
    {
        State.PushButton(this);
        State.GiveProduct(this);
    }
}
