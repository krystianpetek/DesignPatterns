using System;
using TemplateMethod.Two.Contracts;

namespace TemplateMethod.Two;

public class Man : CreateHuman
{
    public override void Plec() => Console.WriteLine("Man");
}
