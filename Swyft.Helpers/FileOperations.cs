using Newtonsoft.Json;
using Swyft.Core.Services;
using Swyft.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swyft.Helpers
{
    public class FileOperations
    {
        public static readonly string usersFile = Path.Combine(Environment.CurrentDirectory, "users.json");
        private static readonly string accountsFile = Path.Combine(Environment.CurrentDirectory, "accounts.json");
        private static readonly string transactionsFile = Path.Combine(Environment.CurrentDirectory, "transactions.json");

        public static async Task<bool> WriteJson<T>(T obj, string path)
        {
            try
            {
                string json = JsonConvert.SerializeObject(obj) + Environment.NewLine;
                await File.WriteAllTextAsync(path, json);
                return true;
            }
            catch (Exception)
            {

                throw new Exception("Cannot write to database");
            }
        }

        public static async Task<List<T>> ReadJson<T>(string path)
        {
            var readText = await File.ReadAllTextAsync(path);

            return JsonConvert.DeserializeObject<List<T>>(readText);
        }

        public static async Task<bool> LoadDatabase()
        {
            try
            {
                var users = await ReadJson<User>(usersFile);
                Data.DataStore.Users = users != null ? users : new List<User>();
                UserService.IdCount = Data.DataStore.Users.Count;

                var accounts = await ReadJson<Account>(accountsFile);
                Data.DataStore.Accounts = accounts != null ? accounts : new List<Account>();
                AccountService.IdCount = Data.DataStore.Accounts.Count;

                var trans = await ReadJson<Transaction>(transactionsFile);
                Data.DataStore.Transactions = trans != null ? trans : new List<Transaction>();
                TransactionService.IdCount = Data.DataStore.Transactions.Count;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static async Task<bool> SaveToDatabase()
        {
            try
            {
                await WriteJson<List<User>>(Data.DataStore.Users, usersFile);
                await WriteJson<List<Account>>(Data.DataStore.Accounts, accountsFile);
                await WriteJson<List<Transaction>>(Data.DataStore.Transactions, transactionsFile);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
