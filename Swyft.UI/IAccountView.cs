using Swyft.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swyft.UI
{
    public interface IAccountView
    {
        /// <summary>
        /// Display user dashboard
        /// </summary>
        public void DisplayDashboard();

        /// <summary>
        /// Display account creation form
        /// </summary>
        public void DisplayCreateAccountMenu(User user);

        /// <summary>
        /// Display a menu containing a list of the user's bank accounts
        /// </summary>
        public void DisplayViewAccountMenu(User user);

        /// <summary>
        /// Display view for a single bank account
        /// </summary>
        public void DisplaySingleAccount(Account account);

        /// <summary>
        /// Display form for depositing into user's bank account
        /// </summary>
        /// <param name="account">Bank account to be operated on</param>
        public void DisplayDepositMenu(Account account);

        /// <summary>
        /// Display form for withdrawing from user's bank account
        /// </summary>
        /// <param name="account">Bank account to be operated on</param>
        public void DisplayWithdrawalMenu(Account account);

        /// <summary>
        /// Display form for transferring from user's bank account to another account
        /// </summary>
        /// <param name="account">Bank account to be operated on</param>
        public void DisplayTransferMenu(Account account);

        /// <summary>
        /// Display account statement for a particular bank account
        /// </summary>
        /// <param name="account">Bank account to be operated on</param>
        public void DisplayAccountStatement(Account account);

        /// <summary>
        /// Display balance for a particular bank account
        /// </summary>
        /// <param name="account">Bank account to be operated on</param>
        public void DisplayAccountBalance(Account account);
    }
}
