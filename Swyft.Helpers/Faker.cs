using Swyft.Core.Authentication;
using Swyft.Models;
using Swyft.Core.Services;
using Swyft.Utility;
using static BCrypt.Net.BCrypt;
using Swyft.Data;

namespace Swyft.Helpers
{
    public class Faker
    {
        /// <summary>
        /// Generate fake data and seed data store
        /// </summary>
        public static void Initiate()
        {
            var user = new User(++UserService.IdCount, "Nonso", "Ike", "nonsoike@test.com", HashPassword("noxx2022!"), "1234");

            DataStore.Users.Add(user);
            DataStore.Accounts.Add(new Account(++AccountService.IdCount, user.FullName, "0099844321", AccountType.Current, user.Id));
            DataStore.Accounts.Add(new Account(++AccountService.IdCount, user.FullName, "0033670908", AccountType.Savings, user.Id));
            Auth.Login("nonsoike@test.com", "noxx2022!");
        }
    }
}
