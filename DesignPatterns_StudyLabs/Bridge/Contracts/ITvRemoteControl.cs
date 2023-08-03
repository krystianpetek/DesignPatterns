namespace Bridge.Contracts;

public interface ITvRemoteControl
{
    public ITelevision Television { get; set; }
    public void TurnOn();
    public void TurnOff();
    public void ChangeChannel(int channel);
}
