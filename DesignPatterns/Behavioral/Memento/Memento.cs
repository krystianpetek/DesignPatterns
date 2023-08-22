namespace Memento;

public partial class Originator
{
    public class Snapshot
    {
        private readonly string _time;

        public Snapshot(string time) => _time = time;
        public string GetTime() => _time;
    }
}
