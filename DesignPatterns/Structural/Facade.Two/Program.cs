using Facade.Two.Services;

namespace Facade.Two;

public static class Program
{
    public static void Main()
    {
        TaskService fasada = new TaskService();
        fasada.ExecuteTask135();
        fasada.ExecuteTask3451();
    }
}