using State.Contracts;
using State.States;

namespace State.StateHolder;

class Phone
{
    private IState _currentState;
    public Phone(IState state)
    {
        _currentState = state;
    }
    public Phone() : this(new VibrationState()) { }

    public void SetState(IState state)
    {
        _currentState = state;
    }
    public void Notify()
    {
        _currentState.Alert();
    }
}