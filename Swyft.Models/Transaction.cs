using Swyft.Utility;
using System;

namespace Swyft.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public TransType Type { get; set; }
        public TransCategory Category { get; set; }
        public decimal Amount { get; set; }
        public int AccountId { get; set; }
        public EntityStatus Status { get; set; }
        public string Description { get; set; }
        public decimal AccountBalance { get; set; }
        public DateTime CreatedAt { get; set; }

        public Transaction(int id, TransType type, TransCategory category, decimal amount, int accountId, string description)
        {
            Id = id;
            Type = type;
            Category = category;
            Amount = amount;
            AccountId = accountId;
            Status = EntityStatus.Active;
            Description = description;
            CreatedAt = DateTime.Now;
        }
    }
}
