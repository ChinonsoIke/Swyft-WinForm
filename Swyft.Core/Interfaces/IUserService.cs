using Swyft.Models;

namespace Swyft.Core.Interfaces
{
    public interface IUserService : IService
    {
        /// <summary>
        /// Create new user and add to datastore
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="pin"></param>
        public void Create(string firstName, string lastName, string email, string password, string pin);

        /// <summary>
        /// Retrieve a user object from the data store using the id
        /// </summary>
        /// <param name="id">integer identifier for target user</param>
        /// <returns>target account if found and null if not found</returns>
        public User Get(int id);
    }
}
