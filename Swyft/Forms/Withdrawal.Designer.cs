namespace Swyft.Forms
{
    partial class Withdrawal
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
            this.label2 = new System.Windows.Forms.Label();
            this.Invalid = new System.Windows.Forms.Label();
            this.Amount = new Krypton.Toolkit.KryptonTextBox();
            this.btnWithdraw = new Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Pin = new Krypton.Toolkit.KryptonTextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(101, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Amount";
            // 
            // Invalid
            // 
            this.Invalid.AutoSize = true;
            this.Invalid.BackColor = System.Drawing.Color.Transparent;
            this.Invalid.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Invalid.ForeColor = System.Drawing.Color.Red;
            this.Invalid.Location = new System.Drawing.Point(101, 87);
            this.Invalid.Name = "Invalid";
            this.Invalid.Size = new System.Drawing.Size(49, 25);
            this.Invalid.TabIndex = 22;
            this.Invalid.Text = "label1";
            this.Invalid.Visible = false;
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(179, 136);
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
            this.Amount.TabIndex = 21;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(274, 239);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnWithdraw.Size = new System.Drawing.Size(112, 39);
            this.btnWithdraw.StateCommon.Back.Color1 = System.Drawing.Color.DimGray;
            this.btnWithdraw.StateCommon.Back.Color2 = System.Drawing.Color.Black;
            this.btnWithdraw.StateCommon.Back.ColorAngle = 120F;
            this.btnWithdraw.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnWithdraw.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnWithdraw.StateCommon.Border.Rounding = 20F;
            this.btnWithdraw.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnWithdraw.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWithdraw.TabIndex = 20;
            this.btnWithdraw.Values.Text = "Withdraw";
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(101, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "PIN";
            // 
            // Pin
            // 
            this.Pin.Location = new System.Drawing.Point(179, 183);
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
            this.Pin.TabIndex = 24;
            // 
            // Withdrawal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 351);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Invalid);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.btnWithdraw);
            this.Name = "Withdrawal";
            this.Text = "Withdrawal";
            this.Load += new System.EventHandler(this.Withdrawal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Invalid;
        private Krypton.Toolkit.KryptonTextBox Amount;
        private Krypton.Toolkit.KryptonButton btnWithdraw;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonTextBox Pin;
    }
}