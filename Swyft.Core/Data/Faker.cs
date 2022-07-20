using Swyft.Core.Authentication;
using Swyft.Core.Models;
using Swyft.Core.Services;
using Swyft.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BCrypt.Net.BCrypt;

namespace Swyft.Core.Data
{
    public class Faker
    {
        /// <summary>
        /// Generate fake data and seed data store
        /// </summary>
        public static void Initiate()
        {
            var user = new User(++UserService.IdCount, "Nonso", "Ike", "nonsoike@test.com", HashPassword("noxx2022!"), "1234");
            Auth.CurrentUser = user;

            DataStore.Accounts.Add(new Account(++AccountService.IdCount, user.FullName, "0099844321", AccountType.Current, user.Id));
            DataStore.Accounts.Add(new Account(++AccountService.IdCount, user.FullName, "0033670908", AccountType.Savings, user.Id));
        }
    }
}
