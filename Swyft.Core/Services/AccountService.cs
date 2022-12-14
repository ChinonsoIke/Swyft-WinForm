using Swyft.Core.Authentication;
using Swyft.Data;
using Swyft.Core.Interfaces;
using Swyft.Models;
using Swyft.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace Swyft.Core.Services
{
    public class AccountService : IAccountService
    {
        public static int IdCount { get; set; }

        private readonly ITransactionService _transactionService;
        private readonly ILogger<AccountService> _log;

        public AccountService(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }
        public void Create(string type)
        {
            var user = Auth.CurrentUser;
            IdCount++;
            string accountNumber = GenerateAccountNumber();
            AccountType accountType = type == "1" ? AccountType.Savings : AccountType.Current;

            var account = new Account(IdCount, user.FullName, accountNumber, accountType, user.Id);

            DataStore.Accounts.Add(account);
        }

        public void Delete(int id)
        {
            var account = DataStore.Accounts.FirstOrDefault(x => x.Id == id);
            var transactions= DataStore.Transactions.Where(x => x.AccountId == account.Id);
            
            account.Status = EntityStatus.Inactive;
        }

        public Account Get(int id)
        {
            return DataStore.Accounts.Where(x => x.Status == EntityStatus.Active).First(x => x.Id == id);
        }

        public void Deposit(decimal amount, int accountId)
        {
            if(amount < 0)
            {
                throw new Exception("Why this?");
            }

            var account = Get(accountId);
            account.Balance += amount;

            var transType = TransType.Credit;
            var transCategory = TransCategory.Deposit;
            string transDesc = $"Deposit by {Auth.CurrentUser.FullName}";

            _transactionService.Create(amount, accountId, transType, transCategory, transDesc);
        }

        public void Withdraw(decimal amount, int accountId)
        {
            if (amount < 0)
            {
                throw new Exception("Why this?");
            }

            var account = DataStore.Accounts.First(x => x.Id == accountId);

            if (account.Balance < amount)
            {
                throw new Exception("You have insufficient funds to complete this transaction.");
            }

            if ((account.Type == AccountType.Savings) && (account.Balance - amount <= 1000))
            {
                throw new Exception("You have insufficient funds to complete this transaction.");
            }

            account.Balance -= amount;

            var transType = TransType.Debit;
            var transCategory = TransCategory.Withdrawal;
            string transDesc = $"Withdrawal by {Auth.CurrentUser.FullName}";

            _transactionService.Create(amount, accountId, transType, transCategory, transDesc);
        }

        public void Transfer(decimal amount, int accountId, int destinationAccountId)
        {
            if (amount < 0)
            {
                throw new Exception("Why this?");
            }

            var account = DataStore.Accounts.First(x => x.Id == accountId);
            var destinationAccount = DataStore.Accounts.First(x => x.Id == destinationAccountId);

            if (account.Balance < amount)
            {
                throw new Exception("You have insufficient funds to complete this transaction.");
            }

            if (account.Type == AccountType.Savings)
            {
                if (account.Balance - amount <= 1000)
                {
                    throw new Exception("You have insufficient funds to complete this transaction.");
                }
            }

            account.Balance -= amount;
            
            var transType = TransType.Debit;
            var transCategory = TransCategory.Transfer;
            string transDesc = $"Transfer by {Auth.CurrentUser.FullName}";

            destinationAccount.Balance += amount;

            var transType2 = TransType.Credit;
            var transCategory2 = TransCategory.Deposit;
            string transDesc2 = $"Transfer from {Auth.CurrentUser.FullName}";

            _transactionService.Create(amount, accountId, transType, transCategory, transDesc);
            _transactionService.Create(amount, destinationAccountId, transType2, transCategory2, transDesc2);
        }

        public string GenerateAccountNumber()
        {
            string accountNumber = "00";
            var rand = new Random();

            for (int i = 1; i <= 8; i++)
            {
                int num = rand.Next(10);
                accountNumber += num;
            }

            return accountNumber;
        }

        public List<Account> GetAllUserAccounts(int userId)
        {
            return DataStore.Accounts.Where(x => x.UserId == userId).ToList();
        }
    }
}
