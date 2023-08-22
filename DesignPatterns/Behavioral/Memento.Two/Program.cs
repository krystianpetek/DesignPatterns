using System;
using System.Collections.Generic;

namespace Memento.Two;

public static class Program
{
    public static void Main()
    {
        Document document = new Document();
        DocumentHistory history = new DocumentHistory(document);

        history.Snapshot();
        document.Append("Lorem ipsum dolor sit amet");
        history.Snapshot();
        document.ItalicFont();
        history.Snapshot();
        document.BoldFont();
        history.Snapshot();
        Document("Stworzony dokument", document);
        history.Restore(1);
        Document("Przywrocony do 1 zapisu", document);
        history.Restore(2);
        Document("Przywrocony do 2 zapisu", document);
    }

    private static void Document(string text, Document dokument)
    {
        Console.WriteLine(text);
        Console.WriteLine(dokument);
    }
}
public class Document
{
    private sealed class DocumentState
    {
        public DocumentState(string state)
        {
            State = state;
        }

        public string State { get; }
    }

    private string _html;
    public void Append(string text) => _html += text;
    public void ItalicFont() => _html = "<i>" + _html + "</i>"; 
    public void BoldFont() => _html = "<b>" + _html + "</b>";
    public object SaveState() => new DocumentState(_html);
    public void RestoreState(object documentState) => _html = (documentState as DocumentState).State;
    public override string ToString() => _html;
}

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
