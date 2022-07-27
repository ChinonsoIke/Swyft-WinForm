namespace Swyft.Forms
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AccountSelect = new Krypton.Toolkit.KryptonTextBox();
            this.btnSelectAccount = new Krypton.Toolkit.KryptonButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelGreeting = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 331);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(19, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(505, 137);
            this.dataGridView1.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(524, 100);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(20, 137);
            this.panel5.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(19, 137);
            this.panel4.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.AccountSelect);
            this.panel3.Controls.Add(this.btnSelectAccount);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 237);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(544, 94);
            this.panel3.TabIndex = 3;
            // 
            // AccountSelect
            // 
            this.AccountSelect.Location = new System.Drawing.Point(335, 15);
            this.AccountSelect.Name = "AccountSelect";
            this.AccountSelect.Size = new System.Drawing.Size(49, 31);
            this.AccountSelect.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.AccountSelect.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.AccountSelect.StateCommon.Border.Color2 = System.Drawing.Color.Red;
            this.AccountSelect.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.AccountSelect.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.AccountSelect.StateCommon.Border.Rounding = 5F;
            this.AccountSelect.StateCommon.Border.Width = 1;
            this.AccountSelect.StateCommon.Content.Color1 = System.Drawing.Color.DarkGray;
            this.AccountSelect.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountSelect.TabIndex = 7;
            this.AccountSelect.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // btnSelectAccount
            // 
            this.btnSelectAccount.Location = new System.Drawing.Point(408, 15);
            this.btnSelectAccount.Name = "btnSelectAccount";
            this.btnSelectAccount.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnSelectAccount.Size = new System.Drawing.Size(108, 31);
            this.btnSelectAccount.StateCommon.Back.Color1 = System.Drawing.Color.DimGray;
            this.btnSelectAccount.StateCommon.Back.Color2 = System.Drawing.Color.Black;
            this.btnSelectAccount.StateCommon.Back.ColorAngle = 120F;
            this.btnSelectAccount.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSelectAccount.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSelectAccount.StateCommon.Border.Rounding = 20F;
            this.btnSelectAccount.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSelectAccount.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSelectAccount.TabIndex = 6;
            this.btnSelectAccount.Values.Text = "Select";
            this.btnSelectAccount.Click += new System.EventHandler(this.btnSelectAccount_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select an account to operate with (using S/N):";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelGreeting);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(544, 100);
            this.panel2.TabIndex = 2;
            // 
            // labelGreeting
            // 
            this.labelGreeting.AutoSize = true;
            this.labelGreeting.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGreeting.Location = new System.Drawing.Point(19, 17);
            this.labelGreeting.Name = "labelGreeting";
            this.labelGreeting.Size = new System.Drawing.Size(90, 28);
            this.labelGreeting.TabIndex = 1;
            this.labelGreeting.Text = "Good Day";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(294, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "VIEW YOUR ACCOUNTS";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 351);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private Krypton.Toolkit.KryptonTextBox AccountSelect;
        private Krypton.Toolkit.KryptonButton btnSelectAccount;
        private System.Windows.Forms.Label labelGreeting;
    }
}