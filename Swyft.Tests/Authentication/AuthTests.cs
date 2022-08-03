using Xunit;
using Swyft.Core.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Swyft.Core.Services;

namespace Swyft.Tests
{
    public class AuthTests : IDisposable
    {
        public AuthTests()
        {
            Auth.CurrentUser = null;
            var userService = new UserService();
            userService.Create("Nonso", "Ike", "nonsoike@test.com", "noxx2022!", "1234");
        }

        [Fact()]
        public void LoginTestValid()
        {
            bool result = Auth.Login("nonsoike@test.com", "noxx2022!");

            Assert.True(result);
            Assert.NotNull(Auth.CurrentUser);
        }

        [Theory()]
        [InlineData("nonsoike@abc.com", "noxx2022!")]
        public void LoginTestInvalid(string email, string password)
        {
            Auth.CurrentUser = null;
            bool result = Auth.Login(email, password);

            Assert.False(result);
            Assert.Null(Auth.CurrentUser);
        }

        [Fact()]
        public void LogoutTest()
        {
            Auth.Logout();

            Assert.Null(Auth.CurrentUser);
        }

        public void Dispose()
        {
            Auth.CurrentUser = null;
            UserService.IdCount = 0;
        }
    }
}