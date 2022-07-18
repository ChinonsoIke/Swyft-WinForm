using Swyft.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swyft.Core.Interfaces
{
    public interface IAccountService : IEntityService
    {
        /// <summary>
        /// Create bank account and save to data store
        /// </summary>
        /// <param name="type"></param>
        void Create(string type);

        /// <summary>
        /// retrieve an account from the data store using the id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>target account if found and null if not found</returns>
        Account Get(int id);

        /// <summary>
        /// Deposit into user's account
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="accountId"></param>
        public void Deposit(decimal amount, int accountId);

        /// <summary>
        /// Withdraw from user's account
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="accountId"></param>
        public void Withdraw(decimal amount, int accountId);

        /// <summary>
        /// Transfer from user's account to destination account
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="accountId"></param>
        /// <param name="destinationAccountId"></param>
        public void Transfer(decimal amount, int accountId, int destinationAccountId);

        /// <summary>
        /// Get all accounts that belong to a specific user
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A list of all accounts that belong to the user</returns>
        List<Account> GetAllUserAccounts(int id);
    }
}
