using State.StateHolder;
using State.States;

namespace State;

public static class Program
{
    public static void Main()
    {
        Phone notifications = new Phone();
        notifications.Notify();

        notifications.SetState(new SoundState());
        notifications.Notify();
        
        notifications.SetState(new MuteState());
        notifications.Notify();
        notifications.Notify();
        
        notifications.SetState(new VibrationState());
        notifications.Notify();
    }
}