namespace Stay_Connect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            signUpPnl.Enabled = true;
            signUpPnl.Visible = true;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            signUpPnl.Enabled = false;
            signUpPnl.Visible = false;
        }
    }
}
