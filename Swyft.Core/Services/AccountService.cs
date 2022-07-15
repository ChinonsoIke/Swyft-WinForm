using Swyft.Core.Authentication;
using Swyft.Core.Data;
using Swyft.Core.Interfaces;
using Swyft.Core.Models;
using Swyft.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swyft.Core.Services
{
    public class AccountService : IAccountService
    {
        public static int IdCount { get; set; }
        public void Create(string type)
        {
            var user = Auth.CurrentUser;
            IdCount++;
            string accountNumber= "00";
            AccountType accountType = type == "1" ? AccountType.Savings : AccountType.Current;
            var rand= new Random();
            for (int i = 1; i <= 8; i++)
            {
                int num= rand.Next(10);
                accountNumber += num;
            }
            var account = new Account(IdCount, user.FullName, accountNumber, accountType, user.Id);

            DataStore.Accounts.Add(account);
        }

        public void Delete(int id)
        {
            var account = DataStore.Accounts.FirstOrDefault(x => x.Id == id);
            var transactions= DataStore.Transactions.Where(x => x.AccountId == account.Id);
            foreach (var trans in transactions)
            {
                trans.Status = EntityStatus.Inactive;
            }
            account.Status = EntityStatus.Inactive;
        }

        public void Edit(int id)
        {
            throw new NotImplementedException();
        }

        public Account Get(int id)
        {
            return DataStore.Accounts.Where(x => x.Status == EntityStatus.Active).First(x => x.Id == id);
        }
    }
}
