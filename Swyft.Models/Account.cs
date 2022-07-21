using Swyft.Utility;
using System;
using System.Linq;

namespace Swyft.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public AccountType Type { get; set; }
        public int UserId { get; set; }
        public EntityStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal Balance { get; set; }

        public Account(int id, string accountName, string accountNumber, AccountType type, int userId)
        {
            Id = id;
            AccountName = accountName;
            AccountNumber = accountNumber;
            Type = type;
            UserId = userId;
            Status = EntityStatus.Active;
            CreatedAt = DateTime.Now;
        }
    }
}
