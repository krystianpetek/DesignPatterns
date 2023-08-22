namespace Memento.Two;
public partial class Document
{
    private sealed class DocumentState
    {
        public DocumentState(string state) => State = state;
        public string State { get; }
    }
}
