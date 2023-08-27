using System;
using TemplateMethod.Two.Contracts;

namespace TemplateMethod.Two.Humans;

public class Woman : CreateHuman
{
    public override void Plec() => Console.WriteLine("Woman");
}
