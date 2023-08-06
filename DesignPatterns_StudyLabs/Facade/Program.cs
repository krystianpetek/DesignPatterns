using Facade.Contracts;
using Facade.Repositories;
using Facade.Services;

namespace Facade;

public static class Program
{
    public static void Main()
    {
        IUserService userService = new UserService(new UserRepository());
        userService.NumberOfAddress();
        userService.CreateUser("someemail@gmail.com");
        userService.NumberOfAddress();
        userService.DeleteUser("john.doe@gmail.com");
        userService.NumberOfAddress();
    }
}