using Swyft.Models;
using Swyft.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swyft.Core.Interfaces
{
    public interface ITransactionService : IService
    {
        /// <summary>
        /// Create a transaction and save to data store
        /// </summary>
        /// <param name="type"></param>
        public void Create(decimal amount, int acccountId, TransType transType, TransCategory transCategory, string transDesc);

        /// <summary>
        /// retrieve a transaction from the data store using the id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>target transaction if found and null if not found</returns>
        // public Transaction Get(int id);

        /// <summary>
        /// Get all transactions that belong to a specific bank account
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A list of all transactions that belong to the bank account</returns>
        List<Transaction> GetAllAccountTransactions(int id);
    }
}
