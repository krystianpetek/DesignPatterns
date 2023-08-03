namespace Bridge.Contracts;

public interface ITelevision
{
    public int Channel { get; set; }
    public bool State { get; set; }
    public void TurnOn();
    public void TurnOff();
    public void ChangeChannel(int channel);
    public void DisplayCurrentChannelAndState();
}
