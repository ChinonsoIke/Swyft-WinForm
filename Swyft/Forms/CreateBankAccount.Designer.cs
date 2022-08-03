namespace Swyft.Forms
{
    partial class CreateBankAccount
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
            this.label8 = new System.Windows.Forms.Label();
            this.CurrentRadio = new System.Windows.Forms.RadioButton();
            this.btnCreateBankAccount = new Krypton.Toolkit.KryptonButton();
            this.SavingsRadio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(166, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 23);
            this.label8.TabIndex = 42;
            this.label8.Text = "Select preferred account";
            // 
            // CurrentRadio
            // 
            this.CurrentRadio.AutoSize = true;
            this.CurrentRadio.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentRadio.Location = new System.Drawing.Point(288, 144);
            this.CurrentRadio.Name = "CurrentRadio";
            this.CurrentRadio.Size = new System.Drawing.Size(90, 32);
            this.CurrentRadio.TabIndex = 41;
            this.CurrentRadio.TabStop = true;
            this.CurrentRadio.Text = "Current";
            this.CurrentRadio.UseVisualStyleBackColor = true;
            // 
            // btnCreateBankAccount
            // 
            this.btnCreateBankAccount.Location = new System.Drawing.Point(175, 220);
            this.btnCreateBankAccount.Name = "btnCreateBankAccount";
            this.btnCreateBankAccount.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnCreateBankAccount.Size = new System.Drawing.Size(174, 39);
            this.btnCreateBankAccount.StateCommon.Back.Color1 = System.Drawing.Color.DimGray;
            this.btnCreateBankAccount.StateCommon.Back.Color2 = System.Drawing.Color.Black;
            this.btnCreateBankAccount.StateCommon.Back.ColorAngle = 120F;
            this.btnCreateBankAccount.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCreateBankAccount.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCreateBankAccount.StateCommon.Border.Rounding = 20F;
            this.btnCreateBankAccount.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCreateBankAccount.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreateBankAccount.TabIndex = 39;
            this.btnCreateBankAccount.Values.Text = "Create Account";
            this.btnCreateBankAccount.Click += new System.EventHandler(this.btnCreateBankAccount_Click);
            // 
            // SavingsRadio
            // 
            this.SavingsRadio.AutoSize = true;
            this.SavingsRadio.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SavingsRadio.Location = new System.Drawing.Point(155, 144);
            this.SavingsRadio.Name = "SavingsRadio";
            this.SavingsRadio.Size = new System.Drawing.Size(92, 32);
            this.SavingsRadio.TabIndex = 43;
            this.SavingsRadio.TabStop = true;
            this.SavingsRadio.Text = "Savings";
            this.SavingsRadio.UseVisualStyleBackColor = true;
            // 
            // CreateBankAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 351);
            this.Controls.Add(this.SavingsRadio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CurrentRadio);
            this.Controls.Add(this.btnCreateBankAccount);
            this.Name = "CreateBankAccount";
            this.Text = "CreateBankAccount";
            this.Load += new System.EventHandler(this.CreateBankAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton CurrentRadio;
        private Krypton.Toolkit.KryptonButton btnCreateBankAccount;
        private System.Windows.Forms.RadioButton SavingsRadio;
    }
}