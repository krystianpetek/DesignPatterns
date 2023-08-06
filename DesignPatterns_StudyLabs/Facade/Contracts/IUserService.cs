namespace Facade.Contracts;

interface IUserService
{
    void CreateUser(string email);
    void DeleteUser(string email);
    void NumberOfAddress();
}
