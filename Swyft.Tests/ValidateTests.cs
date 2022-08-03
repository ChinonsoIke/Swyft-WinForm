using Xunit;
using Swyft.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using Autofac.Extras.Moq;
using Swyft.Core.Interfaces;
using Moq;
using Swyft.Core.Services;
using Swyft.Models;
using Swyft.Core.Authentication;
using Swyft.Data;
using System.Linq;

namespace Swyft.Tests
{
    public class ValidateTests
    {
        private Mock<ITransactionService> mockTransService = new Mock<ITransactionService>();
        private readonly AccountService _accountService;

        public ValidateTests()
        {
            var mock = AutoMock.GetLoose();
            _accountService = mock.Create<AccountService>();
            var userService = mock.Create<UserService>();
            userService.Create("John", "Jones", "johnjones@test.com", "john22!", "1234");
            Auth.CurrentUser = DataStore.Users.Last();
        }


        [Theory()]
        [InlineData("Nonso", true)]
        [InlineData("P", false)]
        [InlineData("joe", false)]
        public void CheckNameTest(string name, bool expected)
        {
            bool actual = Validate.CheckName(name);

            Assert.Equal(expected, actual);
        }

        [Theory()]
        [InlineData("johnjones@test.com", true)]
        [InlineData("john@test", false)]
        [InlineData("john.com", false)]
        [InlineData("jj@test.com", false)]
        public void CheckEmailTest(string email, bool expected)
        {
            bool actual = Validate.CheckEmail(email);

            Assert.Equal(expected, actual);
        }

        [Theory()]
        [InlineData("john2022!", true)]
        [InlineData("john@!#$", false)]
        [InlineData("john.123", false)]
        public void CheckPasswordTest(string password, bool expected)
        {
            bool actual = Validate.CheckPassword(password);

            Assert.Equal(expected, actual);
        }

        [Theory()]
        [InlineData("john2022!", "john2022!", true)]
        [InlineData("john2022!", "John2022!", false)]
        public void CheckPasswordMatchTest(string password, string passwordConfirm, bool expected)
        {
            bool actual = Validate.CheckPasswordMatch(password, passwordConfirm);

            Assert.Equal(expected, actual);
        }

        [Theory()]
        [InlineData("1234", true)]
        [InlineData("123456", false)]
        [InlineData("jdjd", false)]
        public void CheckPinTest(string pin, bool expected)
        {
            bool actual = Validate.CheckPin(pin);

            Assert.Equal(expected, actual);
        }

        [Theory()]
        [InlineData("johnjones@test.com", false)]
        [InlineData("john@test.com", true)]
        public void CheckEmailUniqueTest(string email, bool expected)
        {
            bool actual = Validate.CheckEmailUnique(email);

            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void CheckAccountExistsTest_Valid()
        {
            _accountService.Create("1");
            var account = DataStore.Accounts.Last();

            var account2 = Validate.CheckAccountExists(account.AccountNumber, out string message);

            Assert.Same(account, account2);
        }

        [Theory()]
        [InlineData("0099897643", null)]
        [InlineData("sssa0", null)]
        public void CheckAccountExistsTest_Invalid(string num, Account? account)
        {
            var account2 = Validate.CheckAccountExists("0099897643", out string message);

            Assert.Null(account2);
        }
    }
}