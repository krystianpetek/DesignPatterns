using System;
using Facade.Contracts;
using Facade.Repositories;
using Facade.Validators;

namespace Facade.Services;

class UserService : IUserService
{
    private readonly UserRepository _userRepository;

    public UserService(UserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public void CreateUser(string email)
    {
        if (!EmailValidator.IsValidEmail(email))
            throw new ArgumentException("Wrong email address");

        if (!_userRepository.IsEmailFree(email))
            throw new ArgumentException("Email already exists, choose other");

        _userRepository.AddUser(email);
        EmailNotificationService.SendEmail(email, "Welcome to our service");
    }

    public void DeleteUser(string email)
    {
        if (_userRepository.IsEmailFree(email))
            throw new ArgumentException("User not exists");

        _userRepository.RemoveUser(email);
        EmailNotificationService.SendEmail(email, "Goodbye, user has been deleted.");
    }
    public void NumberOfAddress() => Console.WriteLine($"Number of addresses: {_userRepository.Users.Count}");
}
