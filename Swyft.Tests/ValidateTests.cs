using Xunit;
using Swyft.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Swyft.Tests
{
    public class ValidateTests
    {
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
    }
}