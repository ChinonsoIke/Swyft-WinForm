using Krypton.Toolkit;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Swyft.Core.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swyft
{
    public partial class Login : KryptonForm
    {
        private Form1 parentForm;
        private readonly IServiceProvider _serviceProvider;

        public Login(Form1 form1, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            parentForm = form1;
            _serviceProvider = serviceProvider;
        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void kryptonLabel1_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void labelRegister_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            parentForm.OpenChildForm(_serviceProvider.GetRequiredService<Register>());
        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(Auth.Login(Email.Text, Password.Text))
            {
                Log.Information($"Newly logged in user: {Auth.CurrentUser.Email}");

                var dashboard = _serviceProvider.GetRequiredService<Dashboard>();
                parentForm.Hide();
                dashboard.Show();
            }
            else
            {
                Invalid.Visible = true;
                Invalid.Text = "These credentials do not match our records";
            }
        }
    }
}
