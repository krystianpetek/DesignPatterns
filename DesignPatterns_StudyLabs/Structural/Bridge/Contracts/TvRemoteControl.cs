namespace Bridge.Contracts;

public abstract class TvRemoteControl
{
    public ITelevision Television { get; set; }
    public abstract void TurnOn();
    public abstract void TurnOff();
    public abstract void ChangeChannel(int channel);
    
    protected TvRemoteControl(ITelevision television)
    {
        Television = television;
    }
}
