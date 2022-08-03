using Xunit;
using Swyft.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Swyft.Data;
using System.Linq;
using Swyft.Models;
using Swyft.Core.Authentication;

namespace Swyft.Tests
{
    public class TransactionServiceTests
    {
        private TransactionService _transactionService;
        private AccountService _accountService;
        private Account _commonAccount;
        public TransactionServiceTests()
        {
            _transactionService = new TransactionService();
            _accountService = new AccountService(_transactionService);
            var user = new User(1, "John", "Jones", "johnjones@test.com", "john22!", "1234");
            Auth.CurrentUser = user;
            _accountService.Create("1");
            _commonAccount = DataStore.Accounts.Last();
        }

        [Fact()]
        public void CreateTest()
        {
            int initialIdCount = TransactionService.IdCount;
            int initialTransCount = DataStore.Transactions.Count;
            _transactionService.Create(1200m, 1, Utility.TransType.Credit,
                Utility.TransCategory.Deposit, "test");

            Assert.True(initialIdCount < TransactionService.IdCount);
            Assert.True(initialTransCount < DataStore.Transactions.Count);
        }

        [Fact()]
        public void GetAllAccountTransactionsTest()
        {
            _transactionService.Create(1200m, 1, Utility.TransType.Credit,
                Utility.TransCategory.Deposit, "test");
            _transactionService.Create(100m, 1, Utility.TransType.Debit,
                Utility.TransCategory.Withdrawal, "test");

            var expected = _transactionService.GetAllAccountTransactions(_commonAccount.Id);

            Assert.Equal(2, expected.Count);
            Assert.Equal(2, expected.Count(x => x.AccountId == _commonAccount.Id));
        }
    }
}