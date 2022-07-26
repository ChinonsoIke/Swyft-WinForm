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

        private void btnTransfer_Click(object sender, EventArgs e)
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
                        _accountService.Transfer(amount, Auth.UserSelectedBankAccount.Id, destinationAccount.Id);
                        MessageBox.Show("Transfer transaction successful");
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
}
