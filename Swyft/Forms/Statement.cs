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
    public partial class Statement : Form
    {
        private readonly ITransactionService _transactionService;

        public Statement(ITransactionService transactionService)
        {
            InitializeComponent();
            _transactionService = transactionService;
        }

        private void Statement_Load(object sender, EventArgs e)
        {
            LoadTheme();

            var transactions = _transactionService.GetAllAccountTransactions(Auth.UserSelectedBankAccount.Id);

            DataTable dt = new DataTable();
            dt.Columns.Add("DATE", typeof(string));
            dt.Columns.Add("DESCRIPTION", typeof(string));
            dt.Columns.Add("AMOUNT", typeof(string));
            dt.Columns.Add("TYPE", typeof(string));
            dt.Columns.Add("BALANCE", typeof(string));

            foreach (var transaction in transactions)
            {
                dt.Rows.Add(new object[] { transaction.CreatedAt.ToString("d"), transaction.Description, 
                    $"{transaction.Amount:C}", transaction.Type, $"{transaction.AccountBalance:C}" });
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
    }
}
