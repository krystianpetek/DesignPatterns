using TemplateMethod.Two.Contracts;
using TemplateMethod.Two.Humans;

namespace TemplateMethod.Two;

public static class Program
{
    public static void Main()
    {
        CreateHuman human = new Woman();
        human.Create();
    }
}
