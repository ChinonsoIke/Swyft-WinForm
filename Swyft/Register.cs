using Microsoft.Extensions.DependencyInjection;
using Swyft.Core.Authentication;
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
using static BCrypt.Net.BCrypt;

namespace Swyft
{
    public partial class Register : Form
    {
        private Form1 parentForm;
        private readonly IServiceProvider _serviceProvider;
        private readonly IUserService _userService;
        private readonly IAccountService _accountService;

        public Register(Form1 parentForm, IServiceProvider serviceProvider, IUserService userService, IAccountService accountService)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            _serviceProvider = serviceProvider;
            _userService = userService;
            _accountService = accountService;
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            parentForm.OpenChildForm(_serviceProvider.GetRequiredService<Login>());
        }

        private void Register_Click(object sender, EventArgs e)
        {
            var values = new Dictionary<string, string>
            {
                {"firstname", Firstname.Text},
                {"lastname", Lastname.Text},
                {"email", Email.Text},
                {"password", Password.Text},
                {"passwordConfirm", PasswordConfirm.Text},
                {"pin", Pin.Text},
            };

            var register = Helpers.Validate.Register(values);

            if(register.Count(x => !string.IsNullOrEmpty(x.Value)) > 0)
            {
                string messages = "";

                foreach(var item in register)
                {
                    messages += item.Value + "\n";
                }

                MessageBox.Show(messages);
            }
            else
            {
                _userService.Create(Firstname.Text, Lastname.Text, Email.Text, HashPassword(Password.Text), Pin.Text);
                //await FileOperations.SaveToDatabase();

                if (Auth.Login(Email.Text, Password.Text))
                {
                    if (CurrentRadio.Checked)
                    {
                        _accountService.Create("2");
                    }
                    else
                    {
                        _accountService.Create("1");
                    }

                    var account = _accountService.Get(AccountService.IdCount);
                    Auth.UserSelectedBankAccount = account;

                    var dashboard = _serviceProvider.GetRequiredService<Dashboard>();
                    parentForm.Hide();
                    dashboard.Show();
                }
            }
        }

        private void Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void Firstname_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void AccountSelect_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
