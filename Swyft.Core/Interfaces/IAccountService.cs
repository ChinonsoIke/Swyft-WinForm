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
        void Create(string type);
        Account Get(int id);
        public void Deposit(decimal amount, int accountId, out string message);
        public bool Withdraw(decimal amount, int accountId, out string message);
        public bool Transfer(decimal amount, int accountId, int destinationAccountId, out string message);
        List<Account> GetAllUserAccounts(int id);
    }
}
