using Serilog;
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
    public partial class Transfer : Form
    {
        private readonly IAccountService _accountService;

        public Transfer(IAccountService accountService)
        {
            InitializeComponent();
            _accountService = accountService;
        }

        private void Transfer_Load(object sender, EventArgs e)
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

        private async void btnTransfer_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(Amount.Text, out decimal amount))
            {
                Invalid.Visible = true;
                Invalid.Text = "Invalid Amount";
            }
            var destinationAccount = Helpers.Validate.CheckAccountExists(DestAccount.Text, out string message);

            if (destinationAccount == null)
            {
                Invalid.Visible = true;
                Invalid.Text = message;
            }
            else
            {
                if (Pin.Text == Auth.CurrentUser.Pin)
                {
                    try
                    {
                        var account = Auth.UserSelectedBankAccount;
                        _accountService.Transfer(amount, account.Id, destinationAccount.Id);

                        Log.Information($"Successful transfer transaction. Account Name: {account.AccountNumber}, Amount: {amount}, Balance: {account.Balance}");
                        await FileOperations.SaveToDatabaseAsync();
                        MessageBox.Show("Transfer transaction successful");
                    }
                    catch (Exception ex)
                    {
                        Invalid.Visible = true;
                        Invalid.Text = ex.Message;

                        var account = Auth.UserSelectedBankAccount;
                        Log.Information($"Transfer transaction error. Account Name: {account.AccountNumber}, Message: {ex.Message}");
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
}
