using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Vault
{
    class DataDb
    {
        private SqlCommand cmd;
        private string query;
        private SqlDataAdapter sda;
        private DataTable dt;
        private SqlConnection conn = new SqlConnection("Data Source= LOCALHOST; Initial Catalog= Vault; Trusted_Connection=yes");


        public DataTable Select_data()
        {
            conn.Open();
            query = "select * from passwords";
            cmd = new SqlCommand(query, conn);
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
