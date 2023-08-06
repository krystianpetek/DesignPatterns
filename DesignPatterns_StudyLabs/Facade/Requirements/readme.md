# Facade pattern

## Requirement description

Instrukcje
Widzimy kod symulujący proces zakładania nowego konta w portalu społecznościowym 'Start Line'.

Proces zakładania konta wygląda następująco:
walidacja adresu email
sprawdzenie czy email jest wolny (email jest unikalnym identyfikatorem użytkownika)
dodanie użytkownika do bazy danych (lista na potrzeby zadania)
wysłanie maila do użytkownika, z potwierdzeniem założenia konta
Zaczniemy od implementacji brakujących fragmentów kodu (TODO, NotImplementedException), następnie stworzymy metodę umożliwiającą usunięcie użytkownika.

Na usunięcie użytkownika powinno składać się:
sprawdzenie czy użytkownik istnieje (jeśli nie, to przerywamy proces wyrzuceniem wyjątku)
usunięcie użytkownika z bazy danych (lista na potrzeby zadania)
wysłanie maila do użytkownika potwierdzającego usunięcie konta
Wynik:
Aktualna liczba adresow: 2
Welcome to our service someemail@gmail.com
Aktualna liczba adresow: 3
Goodbye john.doe@gmail.com
Aktualna liczba adresow: 2

## Example for to be completed

```csharp
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WzorzecFasada
{
    interface IUserService
    {
        void CreateUser(string email);
    }

    static class EmailNotification
    {
        public static void SendEmail(string to, string subject)
        {
            Console.WriteLine("Sending an email");
        }
    }

    class UserRepository
    {
        private readonly List<string> users = new List<string>
        {
            "john.doe@gmail.com", "sylvester.stallone@gmail.com"
        };

        public bool IsEmailFree(string email)
        {
            throw new NotImplementedException();
            //dopisz implementacje, która zwróci informacje o tym czy email jest dostępny
        }

        public void AddUser(string email)
        {
            throw new NotImplementedException();
            //dopisz implementacje, która doda użytkownika do listy
        }
    }

    static class Validators
    {
        public static bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase);
        }
    }

    class UserService : IUserService
    {
        private readonly UserRepository userRepository = new UserRepository();
        public void CreateUser(string email)
        {
            if (!Validators.IsValidEmail(email))
            {
                throw new ArgumentException("Błędny email");
            }

            // TODO: dodaj sprawdzenie czy email jest wolny, jeśli nie to wyrzuć wyjątek, jeśli tak, kontynuuj wykonywanie funkcji

            userRepository.AddUser(email);
            EmailNotification.SendEmail(email, "Welcome to our service");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IUserService userService = new UserService();
            // TODO: wyświetlić liczbę
            userService.CreateUser("someemail@gmail.com");
            // TODO: wyświetlić liczbę
            // TODO: usunąć użytkownika
            // TODO: wyświetlić liczbę
        }
    }
}
```
