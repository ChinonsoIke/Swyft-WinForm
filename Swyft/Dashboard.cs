using Krypton.Toolkit;
using Microsoft.Extensions.DependencyInjection;
using Swyft.Core.Authentication;
using Swyft.Core.Interfaces;
using Swyft.Forms;
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

namespace Swyft
{
    public partial class Dashboard : KryptonForm
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private readonly IServiceProvider _serviceProvider;
        private readonly IAccountService _accountService;

        public Dashboard(IServiceProvider serviceProvider, IAccountService accountService)
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            _serviceProvider = serviceProvider;
            _accountService = accountService;
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.colors.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.colors.Count);
            }
            tempIndex = index;
            string color = ThemeColor.colors[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if(btnSender != null )
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    if(currentButton.Text.Length < 18)
                        currentButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.primaryColor = color;
                    ThemeColor.secondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control prevButton in panelSidebar.Controls)
            {
                if (prevButton.GetType() == typeof(Button))
                {
                    prevButton.BackColor = Color.FromArgb(0, 0, 0);
                    prevButton.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;
        }

        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(_serviceProvider.GetRequiredService<Home>(), sender);
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            OpenChildForm(_serviceProvider.GetRequiredService<Deposit>(), sender);
        }

        private void btnWithdrawal_Click(object sender, EventArgs e)
        {
            OpenChildForm(_serviceProvider.GetRequiredService<Withdrawal>(), sender);
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            OpenChildForm(_serviceProvider.GetRequiredService<Transfer>(), sender);
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnStatement_Click(object sender, EventArgs e)
        {
            OpenChildForm(_serviceProvider.GetRequiredService<Statement>(), sender);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Auth.Logout();
            MessageBox.Show("You have been logged out");
            var form1 = _serviceProvider.GetRequiredService<Form1>();
            this.Hide();
            form1.Show();
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null) activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            labelTitle.Text = "Dashboard";
            panelTitleBar.BackColor = Color.FromArgb(0, 0, 0);
            panelLogo.BackColor = Color.FromArgb(255, 255, 255);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            OpenChildForm(_serviceProvider.GetRequiredService<Home>());
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            OpenChildForm(_serviceProvider.GetRequiredService<CreateBankAccount>(), sender);
        }

        private void Dashboard_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
