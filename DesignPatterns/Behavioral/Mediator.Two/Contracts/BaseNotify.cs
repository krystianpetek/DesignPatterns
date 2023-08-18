namespace Mediator.Two.Contracts;

public abstract class BaseNotify
{
    protected IMediator _mediator;
    protected BaseNotify(IMediator mediator = null) => SetMediator(mediator);
    public void SetMediator(IMediator mediator) => _mediator = mediator;
    public abstract void Notify();
}
