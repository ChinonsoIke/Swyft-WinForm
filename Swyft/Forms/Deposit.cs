﻿using Swyft.Core.Authentication;
using Swyft.Core.Interfaces;
using Swyft.Core.Services;
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
    public partial class Deposit : Form
    {
        private readonly IAccountService _accountService;

        public Deposit(IAccountService accountService)
        {
            InitializeComponent();
            _accountService = accountService;
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
            //label1.ForeColor = ThemeColor.primaryColor;
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private async void btnDeposit_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(Amount.Text, out decimal amount))
            {
                try
                {
                    _accountService.Deposit(amount, Auth.UserSelectedBankAccount.Id);
                    await FileOperations.SaveToDatabase();

                    MessageBox.Show("Deposit transaction successful");
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
                Invalid.Text = "Invalid amount";
            }
        }
    }
}
