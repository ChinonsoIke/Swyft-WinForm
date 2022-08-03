using Xunit;
using Swyft.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Swyft.Data;
using Swyft.Models;
using Swyft.Core.Authentication;
using Moq;
using Swyft.Core.Interfaces;
using Autofac.Extras.Moq;

namespace Swyft.Tests
{
    public class AccountServiceTests
    {
        private Mock<ITransactionService> mockTransService = new Mock<ITransactionService>();
        private readonly AccountService _accountService;
        private Account _commonAccount;
        public AccountServiceTests()
        {
            var mock = AutoMock.GetLoose();
            _accountService = mock.Create<AccountService>();
            var user = new User(1, "John", "Jones", "johnjones@test.com", "john22!", "1234");
            Auth.CurrentUser = user;
            _accountService.Create("1");
            _commonAccount = DataStore.Accounts.Last();
        }

        [Fact()]
        public void CreateTest()
        {
            int initialIdCount = AccountService.IdCount;
            int initialAccountCount = DataStore.Accounts.Count;
            _accountService.Create("1");

            Assert.NotEqual(initialIdCount, UserService.IdCount);
            Assert.NotEqual(initialAccountCount, DataStore.Accounts.Count);
        }

        [Fact()]
        public void DeleteTest()
        {
            _accountService.Delete(_commonAccount.Id);

            Assert.Equal((int)_commonAccount.Status, (int)Utility.EntityStatus.Inactive);
        }

        [Fact()]
        public void GetTest()
        {
            var account2 = _accountService.Get(_commonAccount.Id);

            Assert.Equal(_commonAccount.Id, account2.Id);
        }

        [Fact()]
        public void DepositTest()
        {
            decimal initBalance = _commonAccount.Balance;

            _accountService.Deposit(12000m, _commonAccount.Id);

            Assert.NotEqual(initBalance, _commonAccount.Balance);
            Assert.True(_commonAccount.Balance > initBalance);
        }

        [Fact()]
        public void DepositTestInvalid()
        {
            Assert.Throws<Exception>(() => _accountService.Deposit(-12000m, _commonAccount.Id));
        }

        [Fact()]
        public void WithdrawTest()
        {
            // arrange
            decimal currentBalance = _commonAccount.Balance;
            _accountService.Deposit(11000m, _commonAccount.Id);

            // act
            _accountService.Withdraw(9000m, _commonAccount.Id);

            Assert.NotEqual(currentBalance, _commonAccount.Balance);
        }

        [Fact()]
        public void WithdrawTestInvalid_NegativeAmount()
        {
            Assert.Throws<Exception>(() => _accountService.Withdraw(-12000m, _commonAccount.Id));
        }

        [Theory()]
        [InlineData(12000)]
        [InlineData(11000)]
        [InlineData(10000)]
        public void WithdrawTestInvalid_InsufficientBalance(decimal amount)
        {
            _accountService.Deposit(11000m, _commonAccount.Id);

            Assert.Throws<Exception>(() => _accountService.Withdraw(amount, _commonAccount.Id));
        }

        [Fact()]
        public void TransferTestValid()
        {
            _accountService.Deposit(11000m, _commonAccount.Id);
            decimal initBalanceCommon = _commonAccount.Balance;
            _accountService.Create("2");
            var account2 = DataStore.Accounts.Last();
            decimal initBalanceAccount2 = account2.Balance;

            _accountService.Transfer(9000m, _commonAccount.Id, account2.Id);

            Assert.NotEqual(initBalanceCommon, _commonAccount.Balance);
            Assert.True(initBalanceCommon > _commonAccount.Balance);

            Assert.NotEqual(initBalanceAccount2, account2.Balance);
            Assert.True(account2.Balance > initBalanceAccount2);
        }

        [Fact()]
        public void TransferTestInvalid_NegativeAmount()
        {
            _accountService.Deposit(11000m, _commonAccount.Id);
            _accountService.Create("2");
            var account2 = DataStore.Accounts.Last();

            Assert.Throws<Exception>(() => _accountService.Transfer(-9000m, _commonAccount.Id, account2.Id));
        }

        [Theory()]
        [InlineData(12000)]
        [InlineData(11000)]
        [InlineData(10000)]
        public void TransferTestInvalid_InsufficientBalance(decimal amount)
        {
            _accountService.Deposit(11000m, _commonAccount.Id);
            _accountService.Create("2");
            var account2 = DataStore.Accounts.Last();

            Assert.Throws<Exception>(() => _accountService.Transfer(amount, _commonAccount.Id, account2.Id));
        }

        [Fact()]
        public void GetAllUserAccountsTest()
        {
            DataStore.Accounts.Clear();
            _accountService.Create("1");
            _accountService.Create("2");

            var expected = _accountService.GetAllUserAccounts(Auth.CurrentUser.Id);

            Assert.Equal(2, expected.Count);
            Assert.Equal(2, expected.Count(x => x.UserId == Auth.CurrentUser.Id));
        }
    }
}