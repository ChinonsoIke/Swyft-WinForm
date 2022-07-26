namespace Swyft.Forms
{
    partial class Deposit
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
            this.btnDeposit = new Krypton.Toolkit.KryptonButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Invalid = new System.Windows.Forms.Label();
            this.Amount = new Krypton.Toolkit.KryptonTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Invalid);
            this.panel1.Controls.Add(this.Amount);
            this.panel1.Controls.Add(this.btnDeposit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 351);
            this.panel1.TabIndex = 0;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(271, 229);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnDeposit.Size = new System.Drawing.Size(112, 39);
            this.btnDeposit.StateCommon.Back.Color1 = System.Drawing.Color.DimGray;
            this.btnDeposit.StateCommon.Back.Color2 = System.Drawing.Color.Black;
            this.btnDeposit.StateCommon.Back.ColorAngle = 120F;
            this.btnDeposit.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDeposit.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnDeposit.StateCommon.Border.Rounding = 20F;
            this.btnDeposit.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDeposit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeposit.TabIndex = 14;
            this.btnDeposit.Values.Text = "Deposit";
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(98, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Amount";
            // 
            // Invalid
            // 
            this.Invalid.AutoSize = true;
            this.Invalid.BackColor = System.Drawing.Color.Transparent;
            this.Invalid.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Invalid.ForeColor = System.Drawing.Color.Red;
            this.Invalid.Location = new System.Drawing.Point(176, 100);
            this.Invalid.Name = "Invalid";
            this.Invalid.Size = new System.Drawing.Size(57, 28);
            this.Invalid.TabIndex = 17;
            this.Invalid.Text = "label1";
            this.Invalid.Visible = false;
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(176, 145);
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
            this.Amount.TabIndex = 16;
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 351);
            this.Controls.Add(this.panel1);
            this.Name = "Deposit";
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.Deposit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Invalid;
        private Krypton.Toolkit.KryptonTextBox Amount;
        private Krypton.Toolkit.KryptonButton btnDeposit;
    }
}