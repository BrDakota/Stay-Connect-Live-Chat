namespace Stay_Connect
{
    partial class Form2
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
            test_lbl = new Label();
            SuspendLayout();
            // 
            // test_lbl
            // 
            test_lbl.AutoSize = true;
            test_lbl.Location = new Point(551, 109);
            test_lbl.Name = "test_lbl";
            test_lbl.Size = new Size(75, 25);
            test_lbl.TabIndex = 0;
            test_lbl.Text = "test text";
            test_lbl.Click += test_lbl_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1253, 726);
            Controls.Add(test_lbl);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label test_lbl;
    }
}