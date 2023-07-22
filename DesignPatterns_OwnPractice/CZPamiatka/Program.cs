using System;
using System.Collections.Generic;

namespace CZPamiatka
{
    internal class Program
    {

        private static void Dokument(string text, Dokument dokument)
        {
            Console.WriteLine(text);
            Console.WriteLine(dokument);
        }
        static void Main(string[] args)
        {
            var dokument = new Dokument();
            var historia = new DokumentHistoria(dokument);

            historia.SnapShot();
            dokument.Dopisz("Lorem ipsum dolor sit amet");
            historia.SnapShot();
            dokument.PochylCzcionke();
            historia.SnapShot();
            dokument.PogrubCzcionke();
            historia.SnapShot();
            Dokument("Stworzony dokument", dokument);
            historia.Restore(1);
            Dokument("Przywrocony do 1 zapisu", dokument);
            historia.Restore(2);
            Dokument("Przywrocony do 2 zapisu", dokument);

        }
    }
    public class Dokument
    {
        private sealed class DokumentStan
        {
            private string _stan;
            public DokumentStan(string stan)
            {
                _stan = stan;
            }
            public string Stan
            {
                get { return _stan; }
            }
        }
        private string _html;
        public void Dopisz(string text)
        {
            _html += text;
        }
        public void PochylCzcionke()
        {
            _html = "<i>" + _html + "</i>";
        }
        public void PogrubCzcionke()
        {
            _html = "<b>" + _html + "</b>";
        }
        public object ZapiszStan()
        {
            return (new Dokument.DokumentStan(_html));
        }
        public void LadujStan(object standoku)
        {
            _html = (standoku as DokumentStan).Stan;
        }
        public override string ToString()
        {
            return _html;
        }
    }
    public class DokumentHistoria
    {
        private List<object> _historia = new List<object>();
        private Dokument _dokument = null;
        public DokumentHistoria(Dokument dokument)
        {
            _dokument = dokument;
        }
        public void SnapShot()
        {
            var memento = _dokument.ZapiszStan();
            _historia.Add(memento);
        }
        public void Restore(int index)
        {
            var memento = _historia[index];
            _dokument.LadujStan(memento);
        }
    }
}
