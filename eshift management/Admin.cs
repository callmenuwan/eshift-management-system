using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace eshift_management
{
    public class Admin : User
    {
        // Overrides the abstract Login method.
        // Authenticates admin by checking credentials against the database.

        public override bool Login(string inputEmail, string inputPassword)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn))
            {
                conn.Open();

                // SQL query to match entered email and password

                string query = "SELECT * FROM Admin WHERE adminEmail = @inputEmail AND adminPassword = @inputPassword";
                SqlCommand cmd = new SqlCommand(query, conn);


                // Pass values securely using parameters to avoid SQL injection

                cmd.Parameters.AddWithValue("@inputEmail", inputEmail);
                cmd.Parameters.AddWithValue("@inputPassword", inputPassword);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Load admin data from database to this object

                    this.Name = reader["adminName"]?.ToString() ?? "";
                    this.Email = reader["adminEmail"]?.ToString() ?? "";
                    this.Password = reader["adminPassword"]?.ToString() ?? "";
                    return true;
                }
                conn.Close();
                return false;
            }
        }


        // Registers a new customer.

        public Customer RegisterCustomer(string custFullName, string custEmail, string custPassword)
        {
            Customer newCustomer = new Customer
            {
                Name = custFullName,
                Email = custEmail,
                Password = custPassword
            };

            // Insert new customer into the database

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn))
            {
                conn.Open();
                string query = "INSERT INTO Customer (CusName, CusEmail, CusPassword) VALUES (@name, @email, @password)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", custFullName);
                cmd.Parameters.AddWithValue("@email", custEmail);
                cmd.Parameters.AddWithValue("@password", custPassword);
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            return newCustomer; // In future, insert into database
        }
    }

}
