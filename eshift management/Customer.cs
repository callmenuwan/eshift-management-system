using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace eshift_management
{
    public class Customer : User
    {
        public override bool Login(string inputEmail, string inputPassword)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn))
            {
                conn.Open();

                // SQL query to match entered email and password

                string query = "SELECT * FROM Customer WHERE CusEmail = @inputEmail AND CusPassword = @inputPassword";
                SqlCommand cmd = new SqlCommand(query, conn);


                // Pass values securely using parameters to avoid SQL injection

                cmd.Parameters.AddWithValue("@inputEmail", inputEmail);
                cmd.Parameters.AddWithValue("@inputPassword", inputPassword);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Load admin data from database to this object

                    this.UId = Convert.ToInt32(reader["CustID"]); 
                    this.Name = reader["CusName"]?.ToString() ?? "";
                    this.Email = reader["CusEmail"]?.ToString() ?? "";
                    this.Password = reader["CusPassword"]?.ToString() ?? "";
                    return true;
                }
                conn.Close();
                return false;
            }
        }
    }

}
