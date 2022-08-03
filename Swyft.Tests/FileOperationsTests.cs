using Xunit;
using Swyft.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Swyft.Core.Services;
using Swyft.Data;
using Swyft.Models;

namespace Swyft.Tests
{
    public class FileOperationsTests : IDisposable
    {
        public void Dispose()
        {
            UserService.IdCount = 0;
            AccountService.IdCount = 0;
            TransactionService.IdCount = 0;

            DataStore.Users = new List<User>();
            DataStore.Accounts = new List<Account>();
            DataStore.Transactions = new List<Transaction>();
        }

        [Fact()]
        public async Task LoadDatabaseAsyncTest()
        {
            Assert.True(await FileOperations.LoadDatabaseAsync());
        }

        [Fact()]
        public async Task SaveToDatabaseAsyncTest()
        {
            await FileOperations.LoadDatabaseAsync();

            Assert.True(await FileOperations.SaveToDatabaseAsync());
        }
    }
}