using Swyft.Models;
using Swyft.Data;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using static System.Console;
using System.Collections.Generic;

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
            return Regex.IsMatch(email, @"^[a-z0-9]{3,20}@[a-z]{3,20}\.[a-z.]{2,}$");
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

        public static Dictionary<string, string> Register(Dictionary<string, string> values)
        {
            string pass = values["password"];
            string email = values["email"];

            values["firstname"] = !CheckName(values["firstname"]) ? "Invalid input for firstname" : "";
            values["lastname"] = !CheckName(values["lastname"]) ? "Invalid input for lastname" : "";
            values["email"] = !CheckEmail(values["email"]) ? "Invalid input for email" : "";
            values["email"] += !CheckEmailUnique(email) ? "A user with this email account already exists" : values["email"];
            values["password"] = !CheckPassword(values["password"]) ? "Invalid input for password" : "";
            values["passwordConfirm"] = !CheckPasswordMatch(pass, values["passwordConfirm"]) ? "Passwords do not match" : "";
            values["pin"] = !CheckPin(values["pin"]) ? "Invalid input for pin" : "";

            return values;
        }
    }
}
