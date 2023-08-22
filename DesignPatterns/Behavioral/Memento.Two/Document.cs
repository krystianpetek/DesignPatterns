namespace Memento.Two;

public partial class Document
{

    private string _html;
    public void Append(string text) => _html += text;
    public void ItalicFont() => _html = "<i>" + _html + "</i>"; 
    public void BoldFont() => _html = "<b>" + _html + "</b>";
    public object SaveState() => new DocumentState(_html);
    public void RestoreState(object documentState) => _html = (documentState as DocumentState).State;
    public override string ToString() => _html;
}
