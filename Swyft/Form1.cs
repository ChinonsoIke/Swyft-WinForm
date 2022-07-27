using Krypton.Toolkit;
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

namespace Swyft
{
    public partial class Form1 : KryptonForm
    {
        private Form activeForm;
        private readonly IServiceProvider _serviceProvider;

        public Form1(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
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
            this.panelAuth.Controls.Add(childForm);
            this.panelAuth.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //Faker.Initiate();
            await FileOperations.LoadDatabase();
            OpenChildForm(_serviceProvider.GetRequiredService<Login>());
        }

        private async void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            await FileOperations.SaveToDatabase();
        }
    }
}
