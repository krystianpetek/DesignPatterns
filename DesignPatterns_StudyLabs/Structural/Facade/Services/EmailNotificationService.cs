using System;

namespace Facade.Services;

public static class EmailNotificationService
{
    public static void SendEmail(string to, string subject)
    {
        Console.WriteLine($"{subject} {to}");
    }
}
