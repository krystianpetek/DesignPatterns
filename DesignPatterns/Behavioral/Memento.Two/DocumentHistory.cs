using System.Collections.Generic;

namespace Memento.Two;

public class DocumentHistory
{
    private readonly List<object> _history = new List<object>();
    private readonly Document _document;

    public DocumentHistory(Document document) => _document = document;
    public void Snapshot()
    {
        object memento = _document.SaveState();
        _history.Add(memento);
    }
    public void Restore(int index)
    {
        object memento = _history[index];
        _document.RestoreState(memento);
    }
}
