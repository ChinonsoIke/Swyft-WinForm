using Swyft.Core.Authentication;
using Swyft.Core.Services;
using Swyft.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Swyft.UI
{
    internal class AuthView
    {
        public static void DisplayAuthMenu()
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

        static bool Login()
        {
            WriteLine("Enter your details to login");
            Write("Email: ");
            string email = ReadLine();

            Write("Password: ");
            string password = ReadLine();

            if (Auth.Login(email, password)) return true;

            WriteLine("Invalid email or password");
            return false;
        }

        static void Register()
        {
            bool invalid = true;
            int count = 0;

            while (invalid && count < 3)
            {
                Write("Firstname: ");
                string firstName = ReadLine();

                Write("Lastname: ");
                string lastName = ReadLine();

                Write("Email: ");
                string email = ReadLine();

                Write("Password: ");
                string password = ReadLine();

                Write("Transaction PIN: ");
                string pin = ReadLine();

                bool detailsValid = Validate.Register(firstName, lastName, email, password, pin, out List<string> messages);

                if (detailsValid)
                {
                    var userService = new UserService();
                    userService.Create(firstName, lastName, email, password, pin);
                    Auth.Login(email, password);
                    invalid = false;
                }
                else
                {
                    foreach (var message in messages)
                    {
                        WriteLine(message);
                    }
                    count++;
                    continue;
                }
            }
        }
    }
}
