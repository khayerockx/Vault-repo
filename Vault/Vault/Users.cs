using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Vault
{
    class Users
    {
        private SqlCommand cmd;
        private string query;
        private SqlDataAdapter sda;
        private DataTable dt;
        private SqlConnection conn = new SqlConnection("Data Source= LOCALHOST; Initial Catalog= Vault; Trusted_Connection=yes");

        private string username;
        private string password;
        private string role;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }

        public DataTable Select_User(string username, string password)
        {
            conn.Open();
            query = "select * from users where username = '" + username + "' and password  = '" + password + "';";
            cmd = new SqlCommand(query, conn);
            dt = new DataTable();
            sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
