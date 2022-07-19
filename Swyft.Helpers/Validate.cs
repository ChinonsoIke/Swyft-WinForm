using Swyft.Core.Data;
using Swyft.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Console;

namespace Swyft.Helpers
{
    public class Validate
    {        
        /// <summary>
        /// Validate name input submitted in by user
        /// </summary>
        /// <param name="name"></param>
        /// <returns>True or false value indicating whether input is valid</returns>
        public static bool CheckName(string name)
        {
            return Regex.IsMatch(name, @"[A-Z][a-z]{2,}");
        }

        /// <summary>
        /// Validate email input submitted in by user
        /// </summary>
        /// <param name="email"></param>
        /// <returns>True or false value indicating whether input is valid</returns>
        public static bool CheckEmail(string email)
        {
            return Regex.IsMatch(email, @"^[a-z0-9]{5,20}@[a-z]{3,20}\.[a-z.]{2,}$");
        }

        /// <summary>
        /// Ensure that email provided by user does not belong to an existing account
        /// </summary>
        /// <param name="email"></param>
        /// <returns>Boolean value indicating whether the email is unique or not</returns>
        public static bool CheckEmailUnique(string email)
        {
            return DataStore.Users.FirstOrDefault(u => u.Email == email) == null;
        }

        /// <summary>
        /// Validate password input submitted in by user
        /// </summary>
        /// <param name="password"></param>
        /// <returns>True or false value indicating whether input is valid</returns>
        public static bool CheckPassword(string password)
        {
            return Regex.IsMatch(password, @"^(?=.*[@$!%*#?&])(?=.*[A-Za-z])(?=.*\d)[A-Za-z0-9@$!%*#?&]{6,}$");
        }

        /// <summary>
        /// Check whether password and password confirmation are the same
        /// </summary>
        /// <param name="password"></param>
        /// <param name="passwordConfirm"></param>
        /// <returns>True or false value indicating whether both strings match</returns>
        public static bool CheckPasswordMatch(string password, string passwordConfirm)
        {
            return password == passwordConfirm;
        }

        /// <summary>
        /// Validate pin input submitted in by user
        /// </summary>
        /// <param name="pin"></param>
        /// <returns>True or false value indicating whether input is valid</returns>
        public static bool CheckPin(string pin)
        {
            return Regex.IsMatch(pin, @"^\d{4}$");
        }

        /// <summary>
        /// Check data store for the existence of a bank account
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <param name="message"></param>
        /// <returns>The target account or null if it doesn't exist</returns>
        public static Account CheckAccountExists(string accountNumber, out string message)
        {
            if (!Regex.IsMatch(accountNumber, @"\d{10}"))
            {
                message = "Invalid input";
                return null;
            }
            var account = DataStore.Accounts.FirstOrDefault(x => x.AccountNumber == accountNumber);
            if (account == null)
            {
                message = "Destination account does not exist.";
            }

            message = String.Empty;
            return account;
        }

        /// <summary>
        /// Get password input from user in masked form
        /// </summary>
        /// <returns>A string inputted by the user</returns>
        public static string GetPassword()
        {
            string pass = string.Empty;
            ConsoleKey key;
            do
            {
                var keyInfo = ReadKey(true);
                key = keyInfo.Key;

                if (key == ConsoleKey.Backspace && pass.Length > 0)
                {
                    Write("\b \b");
                    //pass = pass[0..^1];
                    pass = pass.Substring(0, pass.Length - 1);
                }
                else if (!char.IsControl(keyInfo.KeyChar))
                {
                    Write("*");
                    pass += keyInfo.KeyChar;
                }
            } while (key != ConsoleKey.Enter);
            WriteLine();

            return pass;
        }
    }
}
