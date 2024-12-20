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
            logPassBox = new TextBox();
            logEmailBox = new TextBox();
            emailLbl = new Label();
            passLbl = new Label();
            titleLbl = new Label();
            signUpPnl = new Panel();
            name1Box = new TextBox();
            name2Box = new TextBox();
            userBox = new TextBox();
            signEmailBox = new TextBox();
            signPassBox = new TextBox();
            label6 = new Label();
            signPassLbl = new Label();
            signEmailLbl = new Label();
            userLbl = new Label();
            name2Lbl = new Label();
            name1Lbl = new Label();
            subBtn = new Button();
            signUpPnl.SuspendLayout();
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
            loginBtn.Click += loginBtn_Click;
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
            signUpBtn.Click += signUpBtn_Click;
            // 
            // logPassBox
            // 
            logPassBox.BackColor = Color.FromArgb(64, 64, 64);
            logPassBox.ForeColor = SystemColors.ButtonHighlight;
            logPassBox.Location = new Point(172, 309);
            logPassBox.Name = "logPassBox";
            logPassBox.Size = new Size(390, 31);
            logPassBox.TabIndex = 3;
            // 
            // logEmailBox
            // 
            logEmailBox.BackColor = Color.FromArgb(64, 64, 64);
            logEmailBox.ForeColor = SystemColors.ButtonHighlight;
            logEmailBox.Location = new Point(172, 250);
            logEmailBox.Name = "logEmailBox";
            logEmailBox.Size = new Size(390, 31);
            logEmailBox.TabIndex = 4;
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
            // signUpPnl
            // 
            signUpPnl.Controls.Add(name1Box);
            signUpPnl.Controls.Add(name2Box);
            signUpPnl.Controls.Add(userBox);
            signUpPnl.Controls.Add(signEmailBox);
            signUpPnl.Controls.Add(signPassBox);
            signUpPnl.Controls.Add(label6);
            signUpPnl.Controls.Add(signPassLbl);
            signUpPnl.Controls.Add(signEmailLbl);
            signUpPnl.Controls.Add(userLbl);
            signUpPnl.Controls.Add(name2Lbl);
            signUpPnl.Controls.Add(name1Lbl);
            signUpPnl.Enabled = false;
            signUpPnl.Location = new Point(0, -2);
            signUpPnl.Name = "signUpPnl";
            signUpPnl.Size = new Size(614, 483);
            signUpPnl.TabIndex = 8;
            signUpPnl.Visible = false;
            // 
            // name1Box
            // 
            name1Box.BackColor = Color.FromArgb(64, 64, 64);
            name1Box.ForeColor = SystemColors.ButtonHighlight;
            name1Box.Location = new Point(236, 124);
            name1Box.Name = "name1Box";
            name1Box.Size = new Size(274, 31);
            name1Box.TabIndex = 11;
            // 
            // name2Box
            // 
            name2Box.BackColor = Color.FromArgb(64, 64, 64);
            name2Box.ForeColor = SystemColors.ButtonHighlight;
            name2Box.Location = new Point(236, 173);
            name2Box.Name = "name2Box";
            name2Box.Size = new Size(277, 31);
            name2Box.TabIndex = 10;
            // 
            // userBox
            // 
            userBox.BackColor = Color.FromArgb(64, 64, 64);
            userBox.ForeColor = SystemColors.ButtonHighlight;
            userBox.Location = new Point(236, 226);
            userBox.Name = "userBox";
            userBox.Size = new Size(277, 31);
            userBox.TabIndex = 9;
            // 
            // signEmailBox
            // 
            signEmailBox.BackColor = Color.FromArgb(64, 64, 64);
            signEmailBox.ForeColor = SystemColors.ButtonHighlight;
            signEmailBox.Location = new Point(236, 283);
            signEmailBox.Name = "signEmailBox";
            signEmailBox.Size = new Size(277, 31);
            signEmailBox.TabIndex = 8;
            // 
            // signPassBox
            // 
            signPassBox.BackColor = Color.FromArgb(64, 64, 64);
            signPassBox.ForeColor = SystemColors.ButtonHighlight;
            signPassBox.Location = new Point(236, 339);
            signPassBox.Name = "signPassBox";
            signPassBox.Size = new Size(277, 31);
            signPassBox.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(212, 25);
            label6.Name = "label6";
            label6.Size = new Size(188, 60);
            label6.TabIndex = 5;
            label6.Text = "Sign Up";
            // 
            // signPassLbl
            // 
            signPassLbl.AutoSize = true;
            signPassLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signPassLbl.ForeColor = SystemColors.ButtonHighlight;
            signPassLbl.Location = new Point(96, 336);
            signPassLbl.Name = "signPassLbl";
            signPassLbl.Size = new Size(116, 32);
            signPassLbl.TabIndex = 4;
            signPassLbl.Text = "Password:";
            // 
            // signEmailLbl
            // 
            signEmailLbl.AutoSize = true;
            signEmailLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signEmailLbl.ForeColor = SystemColors.ButtonHighlight;
            signEmailLbl.Location = new Point(96, 280);
            signEmailLbl.Name = "signEmailLbl";
            signEmailLbl.Size = new Size(83, 32);
            signEmailLbl.TabIndex = 3;
            signEmailLbl.Text = "Email: ";
            // 
            // userLbl
            // 
            userLbl.AutoSize = true;
            userLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userLbl.ForeColor = SystemColors.ButtonHighlight;
            userLbl.Location = new Point(96, 223);
            userLbl.Name = "userLbl";
            userLbl.Size = new Size(144, 32);
            userLbl.TabIndex = 2;
            userLbl.Text = "User Name: ";
            // 
            // name2Lbl
            // 
            name2Lbl.AutoSize = true;
            name2Lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name2Lbl.ForeColor = SystemColors.ButtonHighlight;
            name2Lbl.Location = new Point(96, 170);
            name2Lbl.Name = "name2Lbl";
            name2Lbl.Size = new Size(131, 32);
            name2Lbl.TabIndex = 1;
            name2Lbl.Text = "Last Name:";
            // 
            // name1Lbl
            // 
            name1Lbl.AutoSize = true;
            name1Lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name1Lbl.ForeColor = SystemColors.ButtonHighlight;
            name1Lbl.Location = new Point(96, 121);
            name1Lbl.Name = "name1Lbl";
            name1Lbl.Size = new Size(134, 32);
            name1Lbl.TabIndex = 0;
            name1Lbl.Text = "First Name:";
            // 
            // subBtn
            // 
            subBtn.BackColor = Color.RoyalBlue;
            subBtn.ForeColor = SystemColors.ButtonHighlight;
            subBtn.Location = new Point(236, 387);
            subBtn.Name = "subBtn";
            subBtn.Size = new Size(142, 60);
            subBtn.TabIndex = 9;
            subBtn.Text = "Submit";
            subBtn.UseVisualStyleBackColor = false;
            subBtn.Click += subBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(609, 601);
            Controls.Add(subBtn);
            Controls.Add(signUpPnl);
            Controls.Add(titleLbl);
            Controls.Add(passLbl);
            Controls.Add(emailLbl);
            Controls.Add(logEmailBox);
            Controls.Add(logPassBox);
            Controls.Add(signUpBtn);
            Controls.Add(loginBtn);
            Controls.Add(loginLbl);
            Name = "Form1";
            Text = "Form1";
            signUpPnl.ResumeLayout(false);
            signUpPnl.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginLbl;
        private Button loginBtn;
        private Button signUpBtn;
        private TextBox logPassBox;
        private TextBox logEmailBox;
        private Label emailLbl;
        private Label passLbl;
        private Label titleLbl;
        private Panel signUpPnl;
        private TextBox name1Box;
        private TextBox name2Box;
        private TextBox userBox;
        private TextBox signEmailBox;
        private TextBox signPassBox;
        private Label label6;
        private Label signPassLbl;
        private Label signEmailLbl;
        private Label userLbl;
        private Label name2Lbl;
        private Label name1Lbl;
        private Button signSubBtn;
        private Button subBtn;
    }
}
