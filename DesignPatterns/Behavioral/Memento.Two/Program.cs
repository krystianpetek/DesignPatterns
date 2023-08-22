using System;

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