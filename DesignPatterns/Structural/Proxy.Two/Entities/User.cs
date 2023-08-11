namespace Proxy.Two.Entities;

public class User
{
    private readonly string Name = "Krystian";
    private readonly string Surname = "Petek";
    private readonly int Age = 23;
    public readonly Role UserRole;

    public User(Role role)
    {
        UserRole = role;
    }

    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(Surname)}: {Surname}, {nameof(Age)}: {Age}, {nameof(UserRole)}: {UserRole}";
    }
}