namespace Swyft
{
    partial class Register
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
            this.labelRegister = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.Email = new Krypton.Toolkit.KryptonTextBox();
            this.Reg = new Krypton.Toolkit.KryptonButton();
            this.PasswordConfirm = new Krypton.Toolkit.KryptonTextBox();
            this.Password = new Krypton.Toolkit.KryptonTextBox();
            this.Pin = new Krypton.Toolkit.KryptonTextBox();
            this.Firstname = new Krypton.Toolkit.KryptonTextBox();
            this.Lastname = new Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SavingsRadio = new System.Windows.Forms.RadioButton();
            this.CurrentRadio = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.Location = new System.Drawing.Point(279, 392);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(43, 15);
            this.labelRegister.TabIndex = 18;
            this.labelRegister.TabStop = true;
            this.labelRegister.Text = "Sign In";
            this.labelRegister.Click += new System.EventHandler(this.Login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(124, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Already have an Account?";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(61, 104);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(307, 31);
            this.Email.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.Email.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.Email.StateCommon.Border.Color2 = System.Drawing.Color.Red;
            this.Email.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Email.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Email.StateCommon.Border.Rounding = 5F;
            this.Email.StateCommon.Border.Width = 1;
            this.Email.StateCommon.Content.Color1 = System.Drawing.Color.DarkGray;
            this.Email.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Email.TabIndex = 15;
            // 
            // Reg
            // 
            this.Reg.Location = new System.Drawing.Point(161, 340);
            this.Reg.Name = "Reg";
            this.Reg.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.Reg.Size = new System.Drawing.Size(112, 39);
            this.Reg.StateCommon.Back.Color1 = System.Drawing.Color.DimGray;
            this.Reg.StateCommon.Back.Color2 = System.Drawing.Color.Black;
            this.Reg.StateCommon.Back.ColorAngle = 120F;
            this.Reg.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Reg.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Reg.StateCommon.Border.Rounding = 20F;
            this.Reg.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Reg.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Reg.TabIndex = 14;
            this.Reg.Values.Text = "Register";
            this.Reg.Click += new System.EventHandler(this.Register_Click);
            // 
            // PasswordConfirm
            // 
            this.PasswordConfirm.Location = new System.Drawing.Point(215, 167);
            this.PasswordConfirm.Name = "PasswordConfirm";
            this.PasswordConfirm.Size = new System.Drawing.Size(153, 31);
            this.PasswordConfirm.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.PasswordConfirm.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.PasswordConfirm.StateCommon.Border.Color2 = System.Drawing.Color.Red;
            this.PasswordConfirm.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PasswordConfirm.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.PasswordConfirm.StateCommon.Border.Rounding = 5F;
            this.PasswordConfirm.StateCommon.Border.Width = 1;
            this.PasswordConfirm.StateCommon.Content.Color1 = System.Drawing.Color.DarkGray;
            this.PasswordConfirm.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordConfirm.TabIndex = 20;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(61, 167);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(153, 31);
            this.Password.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.Password.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.Password.StateCommon.Border.Color2 = System.Drawing.Color.Red;
            this.Password.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Password.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Password.StateCommon.Border.Rounding = 5F;
            this.Password.StateCommon.Border.Width = 1;
            this.Password.StateCommon.Content.Color1 = System.Drawing.Color.DarkGray;
            this.Password.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password.TabIndex = 21;
            // 
            // Pin
            // 
            this.Pin.Location = new System.Drawing.Point(61, 232);
            this.Pin.Name = "Pin";
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
            this.Pin.TabIndex = 22;
            // 
            // Firstname
            // 
            this.Firstname.Location = new System.Drawing.Point(61, 45);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(153, 31);
            this.Firstname.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.Firstname.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.Firstname.StateCommon.Border.Color2 = System.Drawing.Color.Red;
            this.Firstname.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Firstname.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Firstname.StateCommon.Border.Rounding = 5F;
            this.Firstname.StateCommon.Border.Width = 1;
            this.Firstname.StateCommon.Content.Color1 = System.Drawing.Color.DarkGray;
            this.Firstname.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Firstname.TabIndex = 24;
            this.Firstname.TextChanged += new System.EventHandler(this.Firstname_TextChanged);
            // 
            // Lastname
            // 
            this.Lastname.Location = new System.Drawing.Point(215, 45);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(153, 31);
            this.Lastname.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.Lastname.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.Lastname.StateCommon.Border.Color2 = System.Drawing.Color.Red;
            this.Lastname.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Lastname.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Lastname.StateCommon.Border.Rounding = 5F;
            this.Lastname.StateCommon.Border.Width = 1;
            this.Lastname.StateCommon.Content.Color1 = System.Drawing.Color.DarkGray;
            this.Lastname.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lastname.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Firstname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Lastname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Transaction PIN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 15);
            this.label5.TabIndex = 33;
            this.label5.Text = "Confirm Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 34;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 35;
            this.label7.Text = "Email";
            // 
            // SavingsRadio
            // 
            this.SavingsRadio.AutoSize = true;
            this.SavingsRadio.Location = new System.Drawing.Point(65, 296);
            this.SavingsRadio.Name = "SavingsRadio";
            this.SavingsRadio.Size = new System.Drawing.Size(65, 19);
            this.SavingsRadio.TabIndex = 36;
            this.SavingsRadio.TabStop = true;
            this.SavingsRadio.Text = "Savings";
            this.SavingsRadio.UseVisualStyleBackColor = true;
            // 
            // CurrentRadio
            // 
            this.CurrentRadio.AutoSize = true;
            this.CurrentRadio.Location = new System.Drawing.Point(149, 296);
            this.CurrentRadio.Name = "CurrentRadio";
            this.CurrentRadio.Size = new System.Drawing.Size(65, 19);
            this.CurrentRadio.TabIndex = 37;
            this.CurrentRadio.TabStop = true;
            this.CurrentRadio.Text = "Current";
            this.CurrentRadio.UseVisualStyleBackColor = true;
            this.CurrentRadio.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 15);
            this.label8.TabIndex = 38;
            this.label8.Text = "Select preferred account";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CurrentRadio);
            this.Controls.Add(this.SavingsRadio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Firstname);
            this.Controls.Add(this.Lastname);
            this.Controls.Add(this.Pin);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.PasswordConfirm);
            this.Controls.Add(this.labelRegister);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Reg);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel labelRegister;
        private System.Windows.Forms.Label label3;
        private Krypton.Toolkit.KryptonTextBox Email;
        private Krypton.Toolkit.KryptonButton Reg;
        private Krypton.Toolkit.KryptonTextBox PasswordConfirm;
        private Krypton.Toolkit.KryptonTextBox Password;
        private Krypton.Toolkit.KryptonTextBox Pin;
        private Krypton.Toolkit.KryptonTextBox Firstname;
        private Krypton.Toolkit.KryptonTextBox Lastname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton SavingsRadio;
        private System.Windows.Forms.RadioButton CurrentRadio;
        private System.Windows.Forms.Label label8;
    }
}