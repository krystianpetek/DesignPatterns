using System.Text.RegularExpressions;

namespace Facade.Utils;

public static class EmailValidator
{
    public static bool IsValidEmail(string email)
    {
        return Regex.IsMatch(
            input: email,
            pattern: @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
            options: RegexOptions.IgnoreCase);
    }
}
