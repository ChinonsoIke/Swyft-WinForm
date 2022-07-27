using Swyft.Core.Authentication;
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
    public partial class Withdrawal : Form
    {
        private readonly IAccountService _accountService;

        public Withdrawal(IAccountService accountService)
        {
            InitializeComponent();
            _accountService = accountService;
        }

        private void Withdrawal_Load(object sender, EventArgs e)
        {
            LoadTheme();
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

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(Amount.Text, out decimal amount))
            {
                Invalid.Visible = true;
                Invalid.Text = "Invalid Amount";
            }

            if (Pin.Text == Auth.CurrentUser.Pin)
            {
                try
                {
                    _accountService.Withdraw(amount, Auth.UserSelectedBankAccount.Id);
                    //await FileOperations.SaveToDatabase();
                    MessageBox.Show("Withdrawal transaction successful");
                }
                catch (Exception ex)
                {
                    Invalid.Visible = true;
                    Invalid.Text = ex.Message;
                }
            }
            else
            {
                Invalid.Visible = true;
                Invalid.Text = "Invalid Transaction PIN";
            }
        }
    }
}
