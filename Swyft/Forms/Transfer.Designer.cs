namespace Swyft.Forms
{
    partial class Transfer
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
            this.label1 = new System.Windows.Forms.Label();
            this.Pin = new Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Invalid = new System.Windows.Forms.Label();
            this.DestAccount = new Krypton.Toolkit.KryptonTextBox();
            this.btnTransfer = new Krypton.Toolkit.KryptonButton();
            this.label3 = new System.Windows.Forms.Label();
            this.Amount = new Krypton.Toolkit.KryptonTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(100, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 22);
            this.label1.TabIndex = 31;
            this.label1.Text = "PIN";
            // 
            // Pin
            // 
            this.Pin.Location = new System.Drawing.Point(178, 176);
            this.Pin.Name = "Pin";
            this.Pin.PasswordChar = '*';
            this.Pin.Size = new System.Drawing.Size(307, 31);
            this.Pin.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.Pin.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.Pin.StateCommon.Border.Color2 = System.Drawing.Color.Red;
            this.Pin.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Pin.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Pin.StateCommon.Border.Rounding = 5F;
            this.Pin.StateCommon.Border.Width = 1;
            this.Pin.StateCommon.Content.Color1 = System.Drawing.Color.DarkGray;
            this.Pin.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Pin.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(28, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 29;
            this.label2.Text = "Destination Account";
            // 
            // Invalid
            // 
            this.Invalid.AutoSize = true;
            this.Invalid.BackColor = System.Drawing.Color.Transparent;
            this.Invalid.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Invalid.ForeColor = System.Drawing.Color.Red;
            this.Invalid.Location = new System.Drawing.Point(100, 46);
            this.Invalid.Name = "Invalid";
            this.Invalid.Size = new System.Drawing.Size(49, 25);
            this.Invalid.TabIndex = 28;
            this.Invalid.Text = "label1";
            this.Invalid.Visible = false;
            // 
            // DestAccount
            // 
            this.DestAccount.Location = new System.Drawing.Point(178, 83);
            this.DestAccount.Name = "DestAccount";
            this.DestAccount.Size = new System.Drawing.Size(307, 31);
            this.DestAccount.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.DestAccount.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.DestAccount.StateCommon.Border.Color2 = System.Drawing.Color.Red;
            this.DestAccount.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DestAccount.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.DestAccount.StateCommon.Border.Rounding = 5F;
            this.DestAccount.StateCommon.Border.Width = 1;
            this.DestAccount.StateCommon.Content.Color1 = System.Drawing.Color.DarkGray;
            this.DestAccount.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DestAccount.TabIndex = 27;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(273, 232);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnTransfer.Size = new System.Drawing.Size(112, 39);
            this.btnTransfer.StateCommon.Back.Color1 = System.Drawing.Color.DimGray;
            this.btnTransfer.StateCommon.Back.Color2 = System.Drawing.Color.Black;
            this.btnTransfer.StateCommon.Back.ColorAngle = 120F;
            this.btnTransfer.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTransfer.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnTransfer.StateCommon.Border.Rounding = 20F;
            this.btnTransfer.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTransfer.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTransfer.TabIndex = 26;
            this.btnTransfer.Values.Text = "Transfer";
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(100, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 22);
            this.label3.TabIndex = 33;
            this.label3.Text = "Amount";
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(178, 130);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(307, 31);
            this.Amount.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.Amount.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.Amount.StateCommon.Border.Color2 = System.Drawing.Color.Red;
            this.Amount.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Amount.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Amount.StateCommon.Border.Rounding = 5F;
            this.Amount.StateCommon.Border.Width = 1;
            this.Amount.StateCommon.Content.Color1 = System.Drawing.Color.DarkGray;
            this.Amount.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Amount.TabIndex = 32;
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 351);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Invalid);
            this.Controls.Add(this.DestAccount);
            this.Controls.Add(this.btnTransfer);
            this.Name = "Transfer";
            this.Text = "Transfer";
            this.Load += new System.EventHandler(this.Transfer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonTextBox Pin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Invalid;
        private Krypton.Toolkit.KryptonTextBox DestAccount;
        private Krypton.Toolkit.KryptonButton btnTransfer;
        private System.Windows.Forms.Label label3;
        private Krypton.Toolkit.KryptonTextBox Amount;
    }
}