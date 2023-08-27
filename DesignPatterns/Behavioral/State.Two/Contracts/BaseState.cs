using State.Two.StateHolder;

namespace State.Two.Contracts;

public abstract class BaseState
{
    public abstract void PutCoin(StateMachine context);
    public abstract void ReturnCoin(StateMachine context);
    public abstract void PushButton(StateMachine context);
    public abstract void GiveProduct(StateMachine context);
}
