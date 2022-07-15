using Swyft.Core.Authentication;
using Swyft.Core.Data;
using Swyft.Core.Interfaces;
using Swyft.Core.Models;
using Swyft.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public IEntity Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Deposit(decimal amount, int accountId, out string message)
        {
            var transType = TransType.Credit;
            var transCategory = TransCategory.Deposit;
            string transDesc = $"Deposit by {Auth.CurrentUser.FullName}";

            var transService = new TransactionService();
            transService.Create(amount, accountId, transType, transCategory, transDesc);

            message = "Deposit transaction successful.";
        }

        public bool Withdraw(decimal amount, int accountId, out string message)
        {
            var account= DataStore.Accounts.First(x => x.Id == accountId);

            if(account.Type == AccountType.Savings)
            {
                if(account.Balance - amount < 1000)
                {
                    message = "You have insufficient funds to complete this transaction.";
                    return false;
                }
            }else if(account.Type == AccountType.Current)
            {
                if(account.Balance < amount)
                {
                    message = "You have insufficient funds to complete this transaction.";
                    return false;
                }
            }

            var transType = TransType.Debit;
            var transCategory = TransCategory.Withdrawal;
            string transDesc = $"Withdrawal by {Auth.CurrentUser.FullName}";

            var transService = new TransactionService();
            transService.Create(amount, accountId, transType, transCategory, transDesc);

            message = "Withdrawal transaction successful.";

            return true;
        }

        public bool Transfer(decimal amount, int accountId, int destinationAccountId, out string message)
        {
            var account = DataStore.Accounts.First(x => x.Id == accountId);
            var destinationAccount = DataStore.Accounts.First(x => x.Id == destinationAccountId);

            if (account.Type == AccountType.Savings)
            {
                if (account.Balance - amount < 1000)
                {
                    message = "You have insufficient funds to complete this transaction.";
                    return false;
                }
            }
            else if (account.Type == AccountType.Current)
            {
                if (account.Balance < amount)
                {
                    message = "You have insufficient funds to complete this transaction.";
                    return false;
                }
            }

            var transType = TransType.Debit;
            var transCategory = TransCategory.Transfer;
            string transDesc = $"Transfer by {Auth.CurrentUser.FullName}";

            var transType2 = TransType.Credit;
            var transCategory2 = TransCategory.Deposit;
            string transDesc2 = $"Transfer from {Auth.CurrentUser.FullName}";

            var transService = new TransactionService();
            transService.Create(amount, accountId, transType, transCategory, transDesc);
            transService.Create(amount, destinationAccountId, transType2, transCategory2, transDesc2);

            message = "Transfer transaction successful.";

            return true;
        }
    }
}
