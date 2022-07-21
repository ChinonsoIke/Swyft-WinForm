using Swyft.Core.Interfaces;
using Swyft.Data;
using Swyft.Models;
using System;

namespace Swyft.Core.Services
{
    public class UserService : IUserService
    {
        
        public static int IdCount { get; set; }
        public void Create(string firstName, string lastName, string email, string password, string pin)
        {
            IdCount++;

            var user = new User(IdCount, firstName, lastName, email, password, pin);

            DataStore.Users.Add(user);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(int id)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
