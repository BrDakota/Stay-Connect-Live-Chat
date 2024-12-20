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
            string connectionString;
            MySqlConnection cnn;
            connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");
            cnn = new MySqlConnection(connectionString);
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
                    cnn.Open();

                    bool hasInfo = false;
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = cnn;
                    cmd.CommandText = @"SELECT * FROM users WHERE userName = @logBox OR email = @logBox;";
                    cmd.Parameters.AddWithValue("@logBox", logEmailBox.Text);

                    var reader = cmd.ExecuteReader();
                    {
                        while (reader.Read())
                        {
                            var pass = reader.GetString("_password");
                            var firstName = reader.GetString("firstName");
                            var lastName = reader.GetString("lastName");
                            hasInfo = true;

                            if (pass == logPassBox.Text)
                            {
                                MessageBox.Show($"Log in successful\nName: {firstName} {lastName}");
                            }
                            else
                            {
                                MessageBox.Show("Your user name or password did not match");
                            }
                        }
                    }

                    cnn.Close();

                    if (!hasInfo) // This will return if the database does not return anything from the select
                    {
                        MessageBox.Show("That username or password was incorrect");
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
                    cnn.Open();

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = cnn;
                    cmd.CommandText = $"INSERT INTO users (userName, email, firstName, lastName, _password)" +
                        $"VALUES('{userBox.Text}', '{signEmailBox.Text}', '{name1Box.Text}', '{name2Box.Text}', '{signPassBox.Text}')";
                    var writer = cmd.ExecuteNonQuery();

                    cnn.Close();
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
