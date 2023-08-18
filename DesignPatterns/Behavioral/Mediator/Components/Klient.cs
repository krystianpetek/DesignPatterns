using System;
using Mediator.Contracts;

namespace Mediator.Components;

public class Klient : IUser
{
    private readonly IMediator _mediator;
    private readonly string _login;

    public Klient(IMediator mediator, string login)
    {
        _login = login;
        _mediator = mediator;
    }
    
    public void ReceiveMessage(string message)
    {
        Console.WriteLine($"Client {_login} has received message: {message}");
    }

    public void SendMessage(string message)
    {
        _mediator.NotifyUser(this, $"{_login} send message - {message}");
    }
}
