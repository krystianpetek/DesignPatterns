using System;
using Facade.Two.Tasks;

namespace Facade.Two.Services;

public class TaskService
{
    private readonly Task1 _task1;
    private readonly Task2 _task2;
    private readonly Task3 _task3;
    private readonly Task4 _task4;
    private readonly Task5 _task5;

    public TaskService()
    {
        _task1 = new Task1();
        _task2 = new Task2();
        _task3 = new Task3();
        _task4 = new Task4();
        _task5 = new Task5();
    }
    public void ExecuteTask125()
    {
        Console.WriteLine("Execute task 1, 2 and 5");
        _task1.Execute();
        _task2.Execute();
        _task5.Execute();
    }
    public void ExecuteTask135()
    {
        Console.WriteLine("Execute task 1, 3 and 5");
        _task1.Execute();
        _task3.Execute();
        _task5.Execute();
    }
    public void ExecuteTask3451()
    {
        Console.WriteLine("Execute task 3, 4, 5 and 1");
        _task3.Execute();
        _task4.Execute();
        _task5.Execute();
        _task1.Execute();
    }
}
