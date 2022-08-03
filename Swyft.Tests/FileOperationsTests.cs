using Xunit;
using Swyft.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Swyft.Tests
{
    public class FileOperationsTests
    {
        private readonly string dbPath = Path.Combine(Environment.CurrentDirectory, "test_db");
        private readonly string usersFile;
        private readonly string accountsFile;
        private readonly string transactionsFile;
        public FileOperationsTests()
        {
            usersFile = Path.Combine(dbPath, "users.json");
            accountsFile = Path.Combine(dbPath, "accounts.json");
            transactionsFile = Path.Combine(dbPath, "transactions.json");
        }

        [Fact(Skip = "Not completed")]
        public async void LoadDatabaseAsyncTest()
        {
            // make sure db load does not throw exception
            await FileOperations.LoadDatabaseAsync();
        }

        [Fact(Skip = "Not completed")]
        public async void SaveToDatabaseAsyncTest()
        {
            await FileOperations.SaveToDatabaseAsync();
        }

        [Fact(Skip = "Not completed")]
        public void WriteJsonAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact(Skip = "Not completed")]
        public void ReadJsonAsyncTest()
        {
            Assert.True(false, "This test needs an implementation");
        }
    }
}