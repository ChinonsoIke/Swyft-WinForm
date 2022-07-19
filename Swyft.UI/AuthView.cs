using Swyft.Core.Authentication;
using Swyft.Core.Interfaces;
using Swyft.Helpers;
using System;
using static System.Console;
using static BCrypt.Net.BCrypt;

namespace Swyft.UI
{
    public class AuthView : IAuthView
    {
        private readonly IUserService _userService;

        public AuthView(IUserService userService)
        {
            _userService = userService;
        }

        public void DisplayAuthMenu()
        {
            WriteLine("Welcome, select an option to continue:");
            WriteLine("\t1. Login\n\t2. Register\n\t3. Exit");
            Write("==> ");

            string reply = ReadLine();

            if (reply == "1")
            {
                Login();
            }
            else if (reply == "2")
            {
                Register();
            }else if (reply == "3")
            {
                Environment.Exit(0);
            }
        }

        public void Login()
        {
            int count = 0;

            while (count < 3)
            {
                WriteLine("Enter your details to login");
                Write("Email: ");
                string email = ReadLine();

                Write("Password: ");
                string password = Validate.GetPassword();

                if (Auth.Login(email, password)) break;

                WriteLine("Invalid email or password");
                count++;
            }
        }

        public void Register()
        {
            string firstName = "", lastName = "", email = "", password = "", passwordConfirm = "", pin = "", passwordHash = "";
            WriteLine("Press q at any time to quit:");

            while (true)
            {
                Write("Firstname: ");
                firstName = ReadLine();

                if (firstName.ToLower() == "q") return;

                if (!Validate.CheckName(firstName))
                {
                    WriteLine("Invalid input for Firstname: name must be in Title case.");
                    continue;
                }
                break;
            }

            while (true)
            {
                Write("Lastname: ");
                lastName = ReadLine();

                if (lastName.ToLower() == "q") return;

                if (!Validate.CheckName(lastName))
                {
                    WriteLine("Invalid input for Lastname: name must be in Title case and 3 or more characters long.");
                    continue;
                }
                break;
            }

            while (true)
            {
                Write("Email: ");
                email = ReadLine();

                if (email.ToLower() == "q") return;

                if (!Validate.CheckEmail(email))
                {
                    WriteLine("Invalid input for Email: must be a valid email address.");
                    continue;
                }
                if (!Validate.CheckEmailUnique(email))
                {
                    WriteLine("A user account with this email already exists.");
                    continue;
                }
                break;
            }

            while (true)
            {
                Write("Password: ");
                password = Validate.GetPassword();

                if (password.ToLower() == "q") return;

                if (!Validate.CheckPassword(password))
                {
                    WriteLine("Invalid input for Password: must be minimum 6 characters that include alphanumeric and at least one special character.");
                    continue;
                }
                passwordHash = HashPassword(password);
                break;
            }

            while (true)
            {
                Write("Confirm Password: ");
                passwordConfirm = Validate.GetPassword();

                if (passwordConfirm.ToLower() == "q") return;

                if (!Validate.CheckPasswordMatch(password, passwordConfirm))
                {
                    WriteLine("Passwords do not match.");
                    continue;
                }
                break;
            }

            while (true)
            {
                Write("\nEnter a 4-digit PIN to use for your transactions: ");
                pin = Validate.GetPassword();

                if (pin.ToLower() == "q") return;

                if (!Validate.CheckPin(pin))
                {
                    WriteLine("Invalid input for PIN: must be 4 diigits.");
                    continue;
                }
                break;
            }

            _userService.Create(firstName, lastName, email, passwordHash, pin);
            Auth.Login(email, password);
        }
    }
}
