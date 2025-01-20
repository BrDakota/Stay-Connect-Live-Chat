/*
 * REQUIREMENTS
 * Form 1 should allow the user to sign up and login
 * 
 * Sign up -
 *  if the user is signing up their information should be entered into the database for later use
 *  Username and email should both be unique
 *  
 * Login -
 *  if the user is logging in then the database should match their entered password with the one entered in the database
 *  it should only do this if the username or email match the password entered and the one in the database
*/

using MySql.Data.MySqlClient;

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

        private void subBtn_Click(object sender, EventArgs e)
        {
            if (signUpPnl.Enabled == false)
            {
                // This if for the login in page

                if (logEmailBox.Text == "" || logPassBox.Text == "")
                {
                    MessageBox.Show("You forgot to enter your username and password");
                    return;
                }

                try
                {
                    dbAccess dba = new dbAccess();
                    bool correct = dba.CheckPassword(logEmailBox.Text, logPassBox.Text);

                    if(correct)
                    {
                        Form2 f2 = new Form2();
                        f2.Show();
                        this.Hide();
                    }else
                    {
                        MessageBox.Show("The email or password you entered was not correct");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                // This is for the signup page

                if(userBox.Text == "" || signEmailBox.Text == "" || name1Box.Text == "" || name2Box.Text == "" || signPassBox.Text == "")
                {
                    MessageBox.Show("You forgot some information");
                    return;
                }

                try
                {
                    dbAccess dba = new dbAccess();
                    dba.InsertUser(userBox.Text, name1Box.Text, name2Box.Text, signEmailBox.Text, signPassBox.Text);
                    MessageBox.Show("Thank your for signing up");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
