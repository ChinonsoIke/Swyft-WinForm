using Swyft.Core.Data;
using Swyft.Core.Models;
using System.Linq;
using static BCrypt.Net.BCrypt;

namespace Swyft.Core.Authentication
{
    public class Auth
    {
        public static User CurrentUser { get; set; }

        /// <summary>
        /// Log a user into the application
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns>True if credentials match user in database, or false if no user is found</returns>
        public static bool Login(string email, string password)
        {
            User user = DataStore.Users.FirstOrDefault(x => x.Email == email);

            if (user == null || !Verify(password, user.Password)) return false;
            else
            {
                CurrentUser = user;
                return true;
            }
        }

        /// <summary>
        /// Log user out from the application
        /// </summary>
        public static void Logout()
        {
            CurrentUser = null;
        }
    }
}
