
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WzorzecFasada
{
    interface IUserService
    {
        void CreateUser(string email);
        void DeleteUser(string email);
    }

    static class EmailNotification
    {
        public static void SendEmail(string to, string subject)
        {
            Console.WriteLine($"{subject}: {to}");
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
            if (users.Contains(email)) return false;
            else return true;
        }

        public void AddUser(string email)
        {
            users.Add(email);
        }
        public void DeleteUser(string email)
        {
            Console.WriteLine($"Przed usunięciem: {users.Count}");
            Console.WriteLine($"Wywołuje operacje usunięcia dla uzytkownika: {email}");
            users.Remove(email);
            Console.WriteLine($"Po usunięciu: {users.Count}");
        }
        public List<string> ShowList => users;
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

            if (!(userRepository.IsEmailFree(email)))
                throw new ArgumentException("Email jest zajęty");

            userRepository.AddUser(email);
            EmailNotification.SendEmail(email, "Welcome to our service");
        }

        public void DeleteUser(string email)
        {
            if (userRepository.IsEmailFree(email))
                throw new ArgumentException("Użytkownik nie istnieje");
            userRepository.DeleteUser(email);
            EmailNotification.SendEmail(email, "Twoje konto zostało usunięte");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IUserService userService = new UserService();
            userService.CreateUser("someemail@gmail.com");
            userService.DeleteUser("someemail@gmail.com");
            userService.CreateUser("someemail@gmail.com");
        }
    }

}




//using System;
//using System.Collections.Generic;
//using System.Text.RegularExpressions;

//namespace WzorzecFasada
//{
//    interface IUserService
//    {
//        void CreateUser(string email);
//    }

//    static class EmailNotification
//    {
//        public static void SendEmail(string to, string subject)
//        {
//            Console.WriteLine("Sending an email");
//        }
//    }

//    class UserRepository
//    {
//        private readonly List<string> users = new List<string>
//        {
//            "john.doe@gmail.com", "sylvester.stallone@gmail.com"
//        };

//        public bool IsEmailFree(string email)
//        {
//            throw new NotImplementedException();
//            //dopisz implementacje, która zwróci informacje o tym czy email jest dostępny
//        }

//        public void AddUser(string email)
//        {
//            throw new NotImplementedException();
//            //dopisz implementacje, która doda użytkownika do listy
//        }
//    }

//    static class Validators
//    {
//        public static bool IsValidEmail(string email)
//        {
//            return Regex.IsMatch(email,
//                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
//                    RegexOptions.IgnoreCase);
//        }
//    }

//    class UserService : IUserService
//    {
//        private readonly UserRepository userRepository = new UserRepository();
//        public void CreateUser(string email)
//        {
//            if (!Validators.IsValidEmail(email))
//            {
//                throw new ArgumentException("Błędny email");
//            }

//            // TODO: dodaj sprawdzenie czy email jest wolny, jeśli nie to wyrzuć wyjątek, jeśli tak, kontynuuj wykonywanie funkcji

//            userRepository.AddUser(email);
//            EmailNotification.SendEmail(email, "Welcome to our service");
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            IUserService userService = new UserService();
//            userService.CreateUser("someemail@gmail.com");
//        }
//    }

//}