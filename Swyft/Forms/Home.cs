using Swyft.Core.Authentication;
using Swyft.Core.Interfaces;
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
    public partial class Home : Form
    {
        private readonly IAccountService _accountService;

        public Home(IAccountService accountService)
        {
            InitializeComponent();
            _accountService = accountService;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            LoadTheme();
            var accounts = _accountService.GetAllUserAccounts(Auth.CurrentUser.Id);

            DataTable dt = new DataTable();
            dt.Columns.Add("S/N", typeof(int));
            dt.Columns.Add("NAME", typeof(string));
            dt.Columns.Add("NUMBER", typeof(string));
            dt.Columns.Add("TYPE", typeof(string));
            dt.Columns.Add("BALANCE", typeof(string));

            int count = 0;

            foreach (var account in accounts)
            {
                dt.Rows.Add(new object[] { ++count, account.AccountName, account.AccountNumber, account.Type, $"{account.Balance:N2}" });
            }

            dataGridView1.DataSource = dt;
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.primaryColor;
                    btn.FlatAppearance.BorderColor = ThemeColor.secondaryColor;
                }
            }
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSelectAccount_Click(object sender, EventArgs e)
        {
            var accounts = _accountService.GetAllUserAccounts(Auth.CurrentUser.Id);
            int.TryParse(AccountSelect.Text, out int num);

            if (num > 0 && num <= accounts.Count)
            {
                var account = accounts[num - 1];
                Auth.UserSelectedBankAccount = account;
                MessageBox.Show($"Selected account {account.AccountNumber}");
            }
        }
    }
}
