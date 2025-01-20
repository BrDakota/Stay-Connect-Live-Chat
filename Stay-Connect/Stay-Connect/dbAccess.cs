using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

/*
 * This class will provide quick and easy functions for database access and reuability
 * 
*/ 

namespace Stay_Connect
{
    public class dbAccess
    {
        private string connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");
        private MySqlConnection cnn;

        public string GetUsersInfo(string where)
        {
            // return all user info when given a email or username; seperated by a ^
            cnn = new MySqlConnection(connectionString);

            string infoString = "";
            bool hasInfo = false;

            cnn.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = @"SELECT * FROM users WHERE userName = @where OR email = @where";
            cmd.Parameters.AddWithValue("@where", where);

            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                infoString += reader.GetString("firstName");
                infoString += "^" + reader.GetString("lastName");
                infoString += "^" + reader.GetString("userName");
                infoString += "^" + reader.GetString("email");
            }

            cnn.Close();

            if (!hasInfo) infoString = "nothing";
            return infoString;
        }

        public bool CheckPassword(string where, string pass)
        {
            // This will check a given password at a specified location or username in the db
            cnn = new MySqlConnection(connectionString);
            string dbpass = "";

            cnn.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = @"SElECT _password FROM users WHERE userName = @where OR email = @where";
            cmd.Parameters.AddWithValue("@where", where);

            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dbpass = reader.GetString("_password");
            }

            cnn.Close();
            if (dbpass == pass) return true;
            else return false;
        }

        public void InsertUser(string username, string firstName, string lastName, string email, string password)
        {
            cnn = new MySqlConnection(connectionString);

            cnn.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = $"INSERT INTO users (userName, email, firstName, lastName, _password)" +
                $"VALUES('{username}', '{email}', '{firstName}', '{lastName}', '{password}')";
            cmd.ExecuteNonQuery();
            
            cnn.Close();
        }
    }
}
