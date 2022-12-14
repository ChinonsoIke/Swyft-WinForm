using Xunit;
using Swyft.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Swyft.Data;

namespace Swyft.Tests
{
    public class UserServiceTests
    {
        private readonly UserService _userService;
        public UserServiceTests()
        {
            _userService = new UserService();
        }

        [Fact()]
        public void CreateTest()
        {
            int initialUserCount = DataStore.Users.Count;
            _userService.Create("Nonso", "Ike", "nonsoike@test.com", "noxx2022!", "1234");

            Assert.NotEqual(initialUserCount, DataStore.Users.Count);
        }
    }
}