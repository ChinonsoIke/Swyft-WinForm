using Swyft.Core.Interfaces;
using Swyft.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swyft.Forms
{
    public partial class CreateBankAccount : Form
    {
        private readonly IAccountService _accountService;

        public CreateBankAccount(IAccountService accountService)
        {
            InitializeComponent();
            _accountService = accountService;
        }

        private void btnCreateBankAccount_Click(object sender, EventArgs e)
        {
            if (CurrentRadio.Checked)
            {
                _accountService.Create("2");
            }
            else
            {
                _accountService.Create("1");
            }
            //await FileOperations.SaveToDatabase();
            MessageBox.Show("Account creation successful");
        }
    }
}
