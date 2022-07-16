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
    public class AccountService : IAccountService
    {
        public static int IdCount { get; set; }
        public void Create(string type)
        {
            var user = Auth.CurrentUser;
            IdCount++;
            string accountNumber= "00";
            AccountType accountType = type == "1" ? AccountType.Savings : AccountType.Current;
            var rand= new Random();
            for (int i = 1; i <= 8; i++)
            {
                int num= rand.Next(10);
                accountNumber += num;
            }
            var account = new Account(IdCount, user.FullName, accountNumber, accountType, user.Id);

            DataStore.Accounts.Add(account);
        }

        public void Delete(int id)
        {
            var account = DataStore.Accounts.FirstOrDefault(x => x.Id == id);
            var transactions= DataStore.Transactions.Where(x => x.AccountId == account.Id);
            foreach (var trans in transactions)
            {
                trans.Status = EntityStatus.Inactive;
            }
            account.Status = EntityStatus.Inactive;
        }

        public void Edit(int id)
        {
            throw new NotImplementedException();
        }

        public Account Get(int id)
        {
            return DataStore.Accounts.Where(x => x.Status == EntityStatus.Active).First(x => x.Id == id);
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
            var account = DataStore.Accounts.First(x => x.Id == accountId);

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

        public List<Account> GetAllUserAccounts(int accountId)
        {
            return DataStore.Accounts.Where(x => x.UserId == accountId).ToList();
        }
    }
}
