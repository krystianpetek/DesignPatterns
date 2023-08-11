using System;
using System.Collections.Generic;

namespace Interpreter.Two;

internal class Program
{
    static void Main(string[] args)
    {
        Wyrazenie nowe = new Wyrazenie("425 11 3 + /");
        nowe = new Wyrazenie("5 42 10 - +");
        var wynik = nowe.Interpreter();
        Console.WriteLine(wynik.Interpreter());
    }
}

public class Wyrazenie
{
    string[] _text;
    public Wyrazenie(string linia)
    {
        _text = linia.Split(" ");
    }
    public Operacja Interpreter()
    {
        Stack<Operacja> stos = new Stack<Operacja>();
        foreach (var x in _text)
        {
            Operacja lewo = null;
            Operacja prawo = null;
            switch (x)
            {
                case "+":
                    prawo = stos.Pop();
                    lewo = stos.Pop();
                    stos.Push(new Dodawanie(lewo, prawo));
                    break;
                case "-":
                    prawo = stos.Pop();
                    lewo = stos.Pop();
                    stos.Push(new Odejmowanie(lewo, prawo));
                    break;
                case "*":
                    prawo = stos.Pop();
                    lewo = stos.Pop();
                    stos.Push(new Mnozenie(lewo, prawo));
                    break;
                case "/":
                    prawo = stos.Pop();
                    lewo = stos.Pop();
                    stos.Push(new Dzielenie(lewo, prawo));
                    break;
                case "%":
                    prawo = stos.Pop();
                    lewo = stos.Pop();
                    stos.Push(new Modulo(lewo, prawo));
                    break;
                default:
                    int liczba = int.Parse(x);
                    stos.Push(new Liczba(liczba));
                    break;
            }
        }
        return stos.Pop();
    }
}

public interface Operacja
{
    public int Interpreter();
}

public class Liczba : Operacja
{
    int _value;
    public Liczba(int liczba)
    {
        _value = liczba;
    }
    public int Interpreter()
    {
        return _value;
    }
}

public class Dodawanie : Operacja
{
    private Operacja _lewo = null;
    private Operacja _prawo = null;
    public Dodawanie(Operacja lewo, Operacja prawo)
    {
        _lewo = lewo;
        _prawo = prawo;
    }
    public int Interpreter()
    {
        return _lewo.Interpreter() + _prawo.Interpreter();
    }
}

public class Odejmowanie : Operacja
{
    private Operacja _lewo = null;
    private Operacja _prawo = null;
    public Odejmowanie(Operacja lewo, Operacja prawo)
    {
        _lewo = lewo;
        _prawo = prawo;
    }
    public int Interpreter()
    {
        return _lewo.Interpreter() - _prawo.Interpreter();
    }
}

public class Mnozenie : Operacja
{
    private Operacja _lewo = null;
    private Operacja _prawo = null;
    public Mnozenie(Operacja lewo, Operacja prawo)
    {
        _lewo = lewo;
        _prawo = prawo;
    }
    public int Interpreter()
    {
        return _lewo.Interpreter() * _prawo.Interpreter();
    }
}

public class Dzielenie : Operacja
{
    private Operacja _lewo = null;
    private Operacja _prawo = null;
    public Dzielenie(Operacja lewo, Operacja prawo)
    {
        _lewo = lewo;
        _prawo = prawo;
    }
    public int Interpreter()
    {
        return _lewo.Interpreter() / _prawo.Interpreter();
    }
}

public class Modulo : Operacja
{
    private Operacja _lewo = null;
    private Operacja _prawo = null;
    public Modulo(Operacja lewo, Operacja prawo)
    {
        _lewo = lewo;
        _prawo = prawo;
    }
    public int Interpreter()
    {
        return _lewo.Interpreter() % _prawo.Interpreter();
    }
}
