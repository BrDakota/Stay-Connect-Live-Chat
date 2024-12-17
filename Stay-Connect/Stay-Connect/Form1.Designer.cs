namespace Stay_Connect
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginLbl = new Label();
            loginBtn = new Button();
            signUpBtn = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            emailLbl = new Label();
            passLbl = new Label();
            titleLbl = new Label();
            SuspendLayout();
            // 
            // loginLbl
            // 
            loginLbl.AutoSize = true;
            loginLbl.ForeColor = SystemColors.ControlLightLight;
            loginLbl.Location = new Point(260, 83);
            loginLbl.Name = "loginLbl";
            loginLbl.Size = new Size(0, 25);
            loginLbl.TabIndex = 0;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.RoyalBlue;
            loginBtn.ForeColor = SystemColors.ButtonHighlight;
            loginBtn.Location = new Point(11, 487);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(290, 72);
            loginBtn.TabIndex = 1;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            // 
            // signUpBtn
            // 
            signUpBtn.BackColor = Color.RoyalBlue;
            signUpBtn.ForeColor = SystemColors.ButtonHighlight;
            signUpBtn.Location = new Point(307, 487);
            signUpBtn.Name = "signUpBtn";
            signUpBtn.Size = new Size(290, 72);
            signUpBtn.TabIndex = 2;
            signUpBtn.Text = "Sign Up";
            signUpBtn.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(64, 64, 64);
            textBox1.ForeColor = SystemColors.ButtonHighlight;
            textBox1.Location = new Point(172, 309);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(390, 31);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(64, 64, 64);
            textBox2.ForeColor = SystemColors.ButtonHighlight;
            textBox2.Location = new Point(172, 250);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(390, 31);
            textBox2.TabIndex = 4;
            // 
            // emailLbl
            // 
            emailLbl.AutoSize = true;
            emailLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLbl.ForeColor = SystemColors.ButtonHighlight;
            emailLbl.Location = new Point(43, 247);
            emailLbl.Name = "emailLbl";
            emailLbl.Size = new Size(83, 32);
            emailLbl.TabIndex = 5;
            emailLbl.Text = "Email: ";
            // 
            // passLbl
            // 
            passLbl.AutoSize = true;
            passLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passLbl.ForeColor = SystemColors.ButtonHighlight;
            passLbl.Location = new Point(43, 306);
            passLbl.Name = "passLbl";
            passLbl.Size = new Size(123, 32);
            passLbl.TabIndex = 6;
            passLbl.Text = "Password: ";
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLbl.ForeColor = SystemColors.ButtonHighlight;
            titleLbl.Location = new Point(236, 108);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(142, 60);
            titleLbl.TabIndex = 7;
            titleLbl.Text = "Login";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(609, 601);
            Controls.Add(titleLbl);
            Controls.Add(passLbl);
            Controls.Add(emailLbl);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(signUpBtn);
            Controls.Add(loginBtn);
            Controls.Add(loginLbl);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginLbl;
        private Button loginBtn;
        private Button signUpBtn;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label emailLbl;
        private Label passLbl;
        private Label titleLbl;
    }
}
