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
        private static string dbPath = Path.Combine(Environment.CurrentDirectory, "db");
        private static readonly string usersFile = Path.Combine(dbPath, "users.json");
        private static readonly string accountsFile = Path.Combine(dbPath, "accounts.json");
        private static readonly string transactionsFile = Path.Combine(dbPath, "transactions.json");

        public static async Task<bool> WriteJsonAsync<T>(T obj, string path)
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

        public static async Task<List<T>> ReadJsonAsync<T>(string path)
        {
            var readText = await File.ReadAllTextAsync(path);

            return JsonConvert.DeserializeObject<List<T>>(readText);
        }

        public static async Task<bool> LoadDatabaseAsync()
        {
            try
            {
                var users = await ReadJsonAsync<User>(usersFile);
                Data.DataStore.Users = users != null ? users : new List<User>();
                UserService.IdCount = Data.DataStore.Users.Count;

                var accounts = await ReadJsonAsync<Account>(accountsFile);
                Data.DataStore.Accounts = accounts != null ? accounts : new List<Account>();
                AccountService.IdCount = Data.DataStore.Accounts.Count;

                var trans = await ReadJsonAsync<Transaction>(transactionsFile);
                Data.DataStore.Transactions = trans != null ? trans : new List<Transaction>();
                TransactionService.IdCount = Data.DataStore.Transactions.Count;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static async Task<bool> SaveToDatabaseAsync()
        {
            if (!Directory.Exists(dbPath)) Directory.CreateDirectory(dbPath);
            try
            {
                await WriteJsonAsync<List<User>>(Data.DataStore.Users, usersFile);
                await WriteJsonAsync<List<Account>>(Data.DataStore.Accounts, accountsFile);
                await WriteJsonAsync<List<Transaction>>(Data.DataStore.Transactions, transactionsFile);

                return true;
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                return false;
            }
        }
    }
}
